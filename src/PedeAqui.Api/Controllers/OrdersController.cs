using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PedeAqui.Infra.Publishers.Interfaces;
using PedeAqui.Infra.Publishers.Request;

namespace PedeAqui.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IOrderPublisher _publisher;

        public OrdersController(ILogger<OrdersController> logger, IOrderPublisher publisher)
        {
            _logger = logger;
            _publisher = publisher;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostOrderRequest request)
        {
            _publisher.OrderCreated(request);
            return Accepted();
        }
    }
}
