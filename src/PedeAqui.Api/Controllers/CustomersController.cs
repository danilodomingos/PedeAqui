using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PedeAqui.Api.Models.Request.Customer;
using PedeAqui.Api.Utils;
using PedeAqui.Core.Aggregates.Customer.Repositories;

namespace PedeAqui.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _repository;

        public CustomersController(ILogger<CustomersController> logger, ICustomerRepository repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateCustomer([FromBody] PostCustomerRequest store)
        {
            var model = _mapper.Map<Core.Aggregates.Customer.Entities.Customer>(store);
            var location = this.HttpContext.GetLocation(model.Id);

            _repository.Add(model);
            return Created(location, model);
        }

        [HttpGet("{id:guid}")]
        public IActionResult Get([FromRoute] Guid id)
        {
            var model = _repository.GetById(id);

            if(model == null)
                return NotFound();

            return Ok(model);
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] int pageSize = 20, [FromQuery] int pageNumber = 1)
        {
            return Ok(_repository.GetAll(pageSize : pageSize, pageNumber: pageNumber));
        }

    }
}
