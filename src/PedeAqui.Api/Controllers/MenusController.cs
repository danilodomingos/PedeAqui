using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PedeAqui.Api.Models.Request.Store;
using PedeAqui.Api.Utils;
using PedeAqui.Core.Aggregates.Store.Entities;
using PedeAqui.Core.Aggregates.Store.Repositories;

namespace PedeAqui.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenusController : ControllerBase
    {
        private readonly ILogger<MenusController> _logger;
        private readonly IMapper _mapper;
        private readonly IStoreRepository _repository;

        public MenusController(ILogger<MenusController> logger, IStoreRepository repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateMenu([FromBody] PostStoreRequest store)
        {
            var model = _mapper.Map<Store>(store);
            var location = this.HttpContext.GetLocation(model.Id);

            _repository.Add(model);
            return Created(location, model);
        }

    }
}
