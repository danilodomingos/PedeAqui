using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PedeAqui.Api.Models.Request;
using PedeAqui.Api.Utils;
using PedeAqui.Core.Aggregates.Store.Entities;
using PedeAqui.Core.Aggregates.Store.Repositories;

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
        public IActionResult CreateStore([FromBody] PostStoreRequest store)
        {
            var model = _mapper.Map<Store>(store);
            var location = this.HttpContext.GetLocation(model.Id);

            _repository.Add(model);
            return Created(location, model);
        }

        [HttpGet("{id:guid}")]
        public IActionResult Get([FromRoute] Guid id)
        {
            var model = _repository.GetById(id);

            if(model == null)
                return NotFound(model);

            return Ok(model);
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] int pageSize = 20, [FromQuery] int pageNumber = 1)
        {
            return Ok(_repository.GetAll(pageSize : pageSize, pageNumber: pageNumber));
        }

        [HttpDelete("{id:guid}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            _repository.Delete(id);
            return NoContent();
        }

        [HttpPatch("{id:guid}")]
        public IActionResult Update([FromRoute] Guid id, [FromBody] PatchStoreRequest request)
        {   
            var actual = _repository.GetById(id);

            if(actual == null)
                return NotFound(actual);

            _mapper.Map(request, actual);
            //_repository.Update(actual);

            return Ok(actual);
        }

    }
}
