using System.Threading.Tasks;

namespace MetaMystia.Network;

public class TcpNetworkProvider : INetworkProvider
{
    private TcpServer _server;
    private TcpClientWrapper _client;
    private bool _isServer;

    public event System.Action<string> Connected;
    public event System.Action Disconnected;
    public event System.Action<NetPacket> PacketReceived;

    public bool IsConnected => _isServer ? _server?.HasAliveClient ?? false : _client?.IsConnected ?? false;
    public bool IsServer => _isServer;
    public string PeerAddress { get; private set; }

    public void StartHost(int port)
    {
        Stop();
        _server = new TcpServer(port);
        _server.ClientConnected += addr => { PeerAddress = addr; Connected?.Invoke(addr); };
        _server.ClientDisconnected += () => { PeerAddress = null; Disconnected?.Invoke(); };
        _server.PacketReceived += PacketReceived;
        _server.Start();
        _isServer = true;
    }

    public async Task<bool> ConnectAsClientAsync(string address, int port)
    {
        if (IsConnected) Stop();
        _client = new TcpClientWrapper(address, port);
        _client.Connected += addr => { PeerAddress = addr; Connected?.Invoke(addr); };
        _client.Disconnected += () => { PeerAddress = null; Disconnected?.Invoke(); };
        _client.PacketReceived += PacketReceived;

        try
        {
            await _client.StartAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public void Send(NetPacket packet)
    {
        if (_isServer)
            _server?.Send(packet);
        else
            _client?.Send(packet);
    }

    public void Disconnect()
    {
        if (_isServer)
            _server?.DisconnectClient();
        else
            _client?.Close();
    }

    public void Stop()
    {
        _server?.Stop();
        _server = null;
        _client?.Close();
        _client = null;
    }
}
