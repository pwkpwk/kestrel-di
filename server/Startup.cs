using com.ambientbytes.kestreldi.server.Services;

public class Startup
{
    private IConfiguration Configuration { get; init; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void Configure(IApplicationBuilder builder)
    {
        builder.UseRouting();
        builder.UseEndpoints(endpoints => endpoints.MapControllers());
    }


    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddScoped<IServiceOne, ServiceOne>();
        services.AddScopedLazy<IServiceOne>();
    }
}
