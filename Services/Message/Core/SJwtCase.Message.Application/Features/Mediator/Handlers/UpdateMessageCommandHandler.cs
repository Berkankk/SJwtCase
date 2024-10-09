using MediatR;
using SJwtCase.Message.Application.Features.Mediator.Commands;
using SJwtCase.Message.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Message.Application.Features.Mediator.Handlers
{
    public class UpdateMessageCommandHandler : IRequestHandler<UpdateMessageCommand>
    {
        private readonly IMessageService _messageService;

        public UpdateMessageCommandHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task Handle(UpdateMessageCommand request, CancellationToken cancellationToken)
        {
            var value = await _messageService.GetMessageById(request.UserMessageID);
            value.NameSurname = request.NameSurname;
            value.UserMessageID = request.UserMessageID;
            value.Subject = request.Subject;
            value.Email = request.Email;
            value.MessageContent = request.MessageContent;
            await _messageService.UpdateMessage(value);
        }
    }
}
