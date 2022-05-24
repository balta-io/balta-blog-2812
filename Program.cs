var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var connectionString =
    app.Configuration.GetConnectionString("DefaultConnection");

var secrets = new Secrets();
app.Configuration.GetSection("Secrets").Bind(secrets);

app.MapGet("/", () => new
{
    ConnectionString = connectionString,
    Secrets = secrets
});

app.UseStaticFiles();

app.Run();

public class Secrets
{
    public string JwtTokenSecret { get; set; } = string.Empty;
    public string ApiKey { get; set; } = string.Empty;
    public string PrivateKey { get; set; } = string.Empty;
}