using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class MyHub : Hub
{
    public async Task SendMessage(string message)
    {
        Console.WriteLine($"Received from client: {message}");
        await Clients.All.SendAsync("ReceiveMessage", message);
    }
}
