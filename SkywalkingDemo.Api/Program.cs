using SkyApm.Utilities.DependencyInjection;

Environment.SetEnvironmentVariable("ASPNETCORE_HOSTINGSTARTUPASSEMBLIES", "SkyAPM.Agent.AspNetCore");
Environment.SetEnvironmentVariable("SKYWALKING__SERVICENAME", "myservice");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSkyApmExtensions(); //ÃÌº”Skywalkingœ‡πÿ≈‰÷√
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
