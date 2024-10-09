using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SJwtCase.Message.Application.Features.Mediator.Commands;
using SJwtCase.Message.Application.Features.Mediator.Queries;

namespace SJwtCase.Message.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MessagesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMessage()
        {
            var value = await _mediator.Send(new GetMessageQuery());
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _mediator.Send(new GetMessageByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageCommand createMessage)
        {
            await _mediator.Send(createMessage);
            return Ok("Mesajınız başarılı bir şekilde oluşturuldu");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMessage(UpdateMessageCommand updateMessage)
        {
            await _mediator.Send(updateMessage);
            return Ok("Mesajınız başarılı bir şekilde güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _mediator.Send(new RemoveMessageCommand(id));
            return Ok("Mesaj başarıyla silindi");
        }
    }
}
