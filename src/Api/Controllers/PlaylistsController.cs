using Application.Commands;
using Application.Queries;
using Application.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PlaylistsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlaylist(int id)
        {
            var results = await _mediator.Send(new GetAllItemsQuery());

            return Ok(results);
        }



    }
}