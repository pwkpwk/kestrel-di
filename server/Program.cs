using Microsoft.AspNetCore;

namespace com.ambientbytes.kestreldi.server
{
    internal class Program
    {
        static Task Main(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build()
                .RunAsync();
        }
    }
}
