using MarabitoLab6.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<Product>();

var app = builder.Build();

app.MapControllers();

app.MapControllerRoute("Default","{controller=BasicController}/{action=Start}");

app.MapGet("/", () => "Hello World!");



app.Run();
