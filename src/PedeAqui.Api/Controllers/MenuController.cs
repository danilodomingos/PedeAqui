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
    public class MenuController : ControllerBase
    {
        private readonly ILogger<MenuController> _logger;
        private readonly IMapper _mapper;
        private readonly IStoreRepository _repository;

        public MenuController(ILogger<MenuController> logger, IStoreRepository repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateMenu([FromBody] StorePostRequest store)
        {
            var model = _mapper.Map<Store>(store);
            var location = this.HttpContext.GetLocation(model.Id);

            _repository.Add(model);
            return Created(location, model);
        }

    }
}
