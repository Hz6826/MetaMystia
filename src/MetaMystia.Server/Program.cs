using System.Net;
using System.Text.Json;

using MetaMystia.Network;

var port = args.Length > 0 ? int.Parse(args[0]) : 40815;
var limit = args.Length > 1 ? int.Parse(args[1]) : 16;
var filterPath = Path.Combine(AppContext.BaseDirectory, "chat-filter.json");
var filter = File.Exists(filterPath)
    ? JsonSerializer.Deserialize<ChatFilterOptions>(File.ReadAllText(filterPath), new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
        ?? throw new InvalidDataException("聊天过滤配置不能为 null。")
    : new ChatFilterOptions();
if (filter.Words == null) throw new InvalidDataException("聊天过滤配置 words 必须为数组。");
await using var server = new Server(new ServerOptions
{
    Address = IPAddress.Any, Port = port, MaxPlayers = limit, Messages = GameMessageRules.Create(), ChatFilter = filter
});
server.CallbackError += error => Console.Error.WriteLine(error);
await server.StartAsync();
Console.WriteLine($"聊天过滤：{(filter.Enabled ? "启用" : "关闭")}；配置：{filterPath}");
Console.WriteLine($"TCP {server.Endpoint}; World 上限 {limit}; {Versions.Current}");
var done = new TaskCompletionSource<bool>();
Console.CancelKeyPress += (_, e) => { e.Cancel = true; done.TrySetResult(true); };
Console.WriteLine("按 Enter 或 Ctrl+C 关闭。");
await Task.WhenAny(done.Task, Task.Run(Console.ReadLine));
