using com.ambientbytes.kestreldi.server.Configuration;
using com.ambientbytes.kestreldi.server.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace com.ambientbytes.kestreldi.server.Controllers
{
    [Produces("text/plain")]
    [Route("api")]
    [Route("api/v2")]
    public class DefaultController : Controller
    {
        private readonly Lazy<IServiceOne> _serviceOne;
        private readonly ILogger _logger;
        private readonly ServiceOneConfiguration _configuration;

        public DefaultController(
            Lazy<IServiceOne> serviceOne,
            ILogger<DefaultController> logger,
            IOptionsSnapshot<ServiceOneConfiguration> donPedro)
        {
            _serviceOne = serviceOne;
            _logger = logger;
            _configuration = donPedro.Value;
        }

        [HttpGet("getdata")]
        public async Task<string> GetData(CancellationToken cancellation)
        {
            return await _serviceOne.Value.RetrieveValue(_logger, _configuration, cancellation);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}