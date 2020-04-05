using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PedeAqui.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly ILogger<StoreController> _logger;

        public StoreController(ILogger<StoreController> logger)
        {
            _logger = logger;
        }
    }
}
