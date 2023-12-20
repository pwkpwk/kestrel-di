using com.ambientbytes.kestreldi.server.Configuration;

namespace com.ambientbytes.kestreldi.server.Services;

/// <summary>
/// Summary description for Class1
/// </summary>
public interface IServiceOne : IDisposable
{
    Task<string> RetrieveValue(ILogger logger, ServiceOneConfiguration configuration, CancellationToken cancellation);
}
