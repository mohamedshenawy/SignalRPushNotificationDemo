using Microsoft.AspNetCore.SignalR;

public class NotificationHub : Hub
{
    public async Task SendNotification(String message)
    {
        await Clients.All.SendAsync("ReceiveNotification" , new ResDTO { StatusCode = 200 , Message = message});
    }   
}


public class ResDTO
{
    public int StatusCode { get; set; }
    public string Message { get; set; }
}