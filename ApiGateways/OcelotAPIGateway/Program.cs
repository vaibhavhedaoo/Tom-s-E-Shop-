using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddJsonFile("ocelot.dev.json", optional: false, reloadOnChange: true);

}
else
{
    builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
}
builder.Services.AddOcelot();
var app = builder.Build();
app.UseOcelot().Wait();

app.MapGet("/", () => "Hello World!");

app.Run();
