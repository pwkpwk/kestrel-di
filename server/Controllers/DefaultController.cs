using com.ambientbytes.kestreldi.server.Services;
using Microsoft.AspNetCore.Mvc;

namespace com.ambientbytes.kestreldi.server.Controllers
{
    [Route("api")]
    public class DefaultController : Controller
    {
        private readonly Lazy<IServiceOne> _serviceOne;
        private readonly ILogger _logger;

        public DefaultController(Lazy<IServiceOne> serviceOne, ILogger<DefaultController> logger)
        {
            _serviceOne = serviceOne;
            _logger = logger;
        }

        [HttpGet("getdata")]
        public async Task<string> GetData(CancellationToken cancellation)
        {
            return await _serviceOne.Value.RetrieveValue(_logger, cancellation);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}