using Microsoft.IdentityModel.Tokens;
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
var endpoint = builder.Configuration["Keys:EndPointAuthKey"];
builder.Services.AddAuthentication().AddJwtBearer(endpoint, option => {     
   option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
   {
       ValidateIssuer = false,
       ValidateAudience = false,
       ValidateLifetime = true,
       ValidateIssuerSigningKey = true,
       ValidIssuer = builder.Configuration["Jwt:Issuer"],
       ValidAudience  = builder.Configuration["Jwt:Audience"],
       IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
       RoleClaimType = "Roles"
   };
});

builder.Services.AddOcelot();
var app = builder.Build();
app.UseOcelot().Wait();

app.MapGet("/", () => "Hello World!");

app.Run();
