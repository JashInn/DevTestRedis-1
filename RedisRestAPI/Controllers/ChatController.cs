using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
namespace RedisRestAPI.Controllers
{
    

    public class MyConnection : PersistentConnection
    {
        protected override Task OnReceived(IRequest req,string clientId, string data)
        {
            // Broadcast data to all clients
            return Connection.Broadcast(data);
        }
    }


    //public class WSChatController : ApiController
    //{
    //    public HttpResponseMessage Get()
    //    {
    //        if (HttpContext.Current.IsWebSocketRequest)
    //        {
    //            HttpContext.Current.AcceptWebSocketRequest(ProcessWSChat);
    //        }
    //        return new HttpResponseMessage(HttpStatusCode.SwitchingProtocols);
    //    }
    //    private async Task ProcessWSChat(AspNetWebSocketContext context)
    //    {
    //        WebSocket socket = context.WebSocket;
    //        while (true)
    //        {
    //            ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[1024]);
    //            WebSocketReceiveResult result = await socket.ReceiveAsync(
    //                buffer, CancellationToken.None);
    //            if (socket.State == WebSocketState.Open)
    //            {
    //                string userMessage = Encoding.UTF8.GetString(
    //                    buffer.Array, 0, result.Count);
    //                userMessage = "You sent: " + userMessage + " at " +
    //                    DateTime.Now.ToLongTimeString();
    //                buffer = new ArraySegment<byte>(
    //                    Encoding.UTF8.GetBytes(userMessage));
    //                await socket.SendAsync(
    //                    buffer, WebSocketMessageType.Text, true, CancellationToken.None);
    //            }
    //            else
    //            {
    //                break;
    //            }
    //        }
    //    }
    //} 
}
