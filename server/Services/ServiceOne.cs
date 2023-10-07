namespace com.ambientbytes.kestreldi.server.Services;

public class ServiceOne : IServiceOne
{
    private bool _disposed;

    async Task<string> IServiceOne.RetrieveValue(ILogger logger, CancellationToken cancellation)
    {
        try
        {
            await Task.Delay(5000, cancellation);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "ServiceOne|failed to retrieve value");
            throw;
        }
        logger.LogInformation("ServiceOne|retrieved the value");
        return "Value";
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            _disposed = true;
        }
    }

    void IDisposable.Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
