using MediatR;
using MediatrCQRS.Med.Commands;
using MediatrCQRS.Med.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatrCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetProductById() { Id = id };

            return Ok(await _mediator.Send(query));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProduct();

            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> InsertProduct(CreateProductCommand command)
        {

            return Ok(await _mediator.Send(command));
        }
    }
}
