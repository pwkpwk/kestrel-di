using Microsoft.AspNetCore;

namespace com.ambientbytes.kestreldi.server
{
    internal class Program
    {
        static Task Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("configuration.json")
                .Build();
            return WebHost.CreateDefaultBuilder(args)
                .UseConfiguration(configuration)
                .UseStartup<Startup>()
                .Build()
                .RunAsync();
        }
    }
}
