using Application.Dto;
using Application.Features.Command;
using Application.Features.Command.CategoryUpdateCommand;
using Application.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator mediator;

        public CategoryController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async  Task<IActionResult> Get()
        {
            var query = new CategoryListQuery();

            return Ok(await mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new CategoryGetByIdQuery() { Id=id};

            return Ok(await mediator.Send(query));
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateCategoryCommand command)
        {
           
            return Ok(await mediator.Send(command));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var query = new DeleteCategoryCommand() { Id = id };

            return Ok(await mediator.Send(query));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryCommand command)
        {
     
            return Ok(await mediator.Send(command));
        }
    }
}
