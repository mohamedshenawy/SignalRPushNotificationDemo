var builder = WebApplication.CreateBuilder(args);
// Add services to the container
builder.Services.AddSignalR();


var app = builder.Build();
app.UseStaticFiles();


// Map the SignalR hub
app.MapHub<NotificationHub>("/notificationHub");


app.MapFallbackToFile("index.html");
app.Run();
