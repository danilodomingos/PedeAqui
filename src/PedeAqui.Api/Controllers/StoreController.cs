using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PedeAqui.Api.Models.Request;
using PedeAqui.Core.Entities;
using PedeAqui.Core.Services.Interfaces;

namespace PedeAqui.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly ILogger<StoreController> _logger;
        private readonly IMapper _mapper;
        private readonly IStoreService _service;

        public StoreController(ILogger<StoreController> logger, IStoreService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateStore([FromBody] StorePostRequest store)
        {
            var model = _mapper.Map<Store>(store);
            _service.Add(model);

            return Ok(model);
        }

    }
}
