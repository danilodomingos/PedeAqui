using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PedeAqui.Api.Models.Request;
using PedeAqui.Api.Utils;
using PedeAqui.Core.Entities;
using PedeAqui.Core.Repositories.Interfaces;

namespace PedeAqui.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly ILogger<StoreController> _logger;
        private readonly IMapper _mapper;
        private readonly IStoreRepository _repository;

        public StoreController(ILogger<StoreController> logger, IStoreRepository repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateStore([FromBody] StorePostRequest store)
        {
            var model = _mapper.Map<Store>(store);
            var location = this.HttpContext.GetLocation(model.Id);

            _repository.Add(model);
            return Created(location, model);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult Get([FromRoute] Guid id)
        {
            return Ok(_repository.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] int pageSize = 20, [FromQuery] int pageNumber = 1)
        {
            return Ok(_repository.GetAll(null, pageSize, pageNumber));
        }

    }
}
