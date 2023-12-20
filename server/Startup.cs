using com.ambientbytes.kestreldi.server.Configuration;
using com.ambientbytes.kestreldi.server.Services;

namespace com.ambientbytes.kestreldi.server
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(IApplicationBuilder builder)
        {
            builder.UseRouting();
            builder.UseEndpoints(endpoints => endpoints.MapControllers());
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<ServiceOneConfiguration>(_configuration);
            services.AddControllers();

            services.AddScoped<IServiceOne, ServiceOne>();
            services.AddScopedLazy<IServiceOne>();
        }
    }    
}
