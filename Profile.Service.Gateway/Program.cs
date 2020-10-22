using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Steeltoe.Management.Endpoint;

namespace Profile.Service.Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging
                     .AddConfiguration(hostingContext.Configuration.GetSection("Logging"))
                     .AddConsole();
                })
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    // Informs the app to use the ocelot.json file
                    config.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();

                })
                .AddHealthActuator()
                .AddInfoActuator()
                .AddLoggersActuator();
    }
}
