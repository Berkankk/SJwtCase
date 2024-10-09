using Microsoft.AspNetCore.Authentication.JwtBearer;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAuthentication().AddJwtBearer("OcelotAuthenticationScheme" ,opt =>
{
    opt.Authority = builder.Configuration["IdentityServerUrl"];  //Koruma alt�na al�yoruz
    opt.Audience = "resource_ocelot";
});



IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("ocelot.json").Build();

builder.Services.AddOcelot(configuration);

var app = builder.Build();
await app.UseOcelot();


app.MapGet("/", () => "Hello World!");

app.Run();
