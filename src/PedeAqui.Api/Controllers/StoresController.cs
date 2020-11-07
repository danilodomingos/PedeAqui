using MediatR;
using Microsoft.AspNetCore.Mvc;
using PedeAqui.Api.Application.Commands;
using PedeAqui.Api.Models.Request.Store;
using PedeAqui.Api.Queries;
using PedeAqui.Api.Utils;
using System;
using System.Threading.Tasks;

namespace PedeAqui.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoresController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StoresController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostStoreRequest store)
        {
            var result = await _mediator.Send(store);
            var location = this.HttpContext.GetLocation(result.Id);

            return Created(location, result);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new GetStoreByIdQuery(id));

            if (result == null)
                return NotFound(result);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetStoreByFilterRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await _mediator.Send(new DeleteStoreCommand(id));
            return NoContent();
        }

        [HttpPatch("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] PatchStoreRequest request)
        {
            request.Id = id;
            var result = await _mediator.Send(request);

            if (result == null)
                return NotFound(result);

            return Ok(result);
        }

    }
}
