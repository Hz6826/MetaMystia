using System.Threading.Tasks;

namespace MetaMystia.Network;

public interface INetworkProvider
{
    // 启动主机
    void StartHost(int port);
    // 连接作为客户端
    Task<bool> ConnectAsClientAsync(string address, int port);
    // 发送数据包
    void Send(NetPacket packet);
    // 断开当前连接
    void Disconnect();
    // 停止所有网络活动
    void Stop();

    // 状态属性
    bool IsConnected { get; }
    bool IsServer { get; }
    string PeerAddress { get; }

    // 事件
    event System.Action<string> Connected;
    event System.Action Disconnected;
    event System.Action<NetPacket> PacketReceived;
}
