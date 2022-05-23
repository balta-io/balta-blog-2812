var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello my change is online!");

app.UseStaticFiles();

app.Run();
