using BoredMCP;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateApplicationBuilder(args);

builder.Logging.AddConsole(opts =>
{
    opts.LogToStandardErrorThreshold = LogLevel.Trace;
});

builder.Services.AddHttpClient("bored", client =>
    client.BaseAddress = new Uri("https://bored-api.appbrewery.com/")
);

builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithToolsFromAssembly();

await builder.Build().RunAsync();
