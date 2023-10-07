namespace com.ambientbytes.kestreldi.server.Services;

public static class LazyInjection
{
    public static IServiceCollection AddScopedLazy<T>(this IServiceCollection services)
    {
        return services.AddScoped(provider => new Lazy<T>(provider.GetService<T>));
    }

    public static IServiceCollection AddTransientLazy<T>(this IServiceCollection services)
    {
        return services.AddTransient(provider => new Lazy<T>(provider.GetService<T>));
    }
}