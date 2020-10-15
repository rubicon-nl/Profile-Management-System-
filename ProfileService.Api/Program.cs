using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Steeltoe.Management.Endpoint;

namespace ProfileService.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            //.ConfigureAppConfiguration((hostingContext, config) =>
            //{
            //    // Informs the app to use the ocelot.json file
            //    config.AddJsonFile("ocelot.json");
            //})
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .AddHealthActuator()
                .AddInfoActuator()
                .AddLoggersActuator();
    }
}
