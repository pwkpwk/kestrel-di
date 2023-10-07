using Microsoft.AspNetCore;

namespace com.ambientbytes.kestreldi.server
{
    internal class Program
    {
        static Task Main(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://*:5000")
                .UseStartup<Startup>()
                .Build()
                .RunAsync();
        }
    }
}
