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
    public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand>
    {
        private readonly IMessageService _messageService;

        public CreateMessageCommandHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            await _messageService.CreateMessage(new Domain.Entities.UserMessage
            {
                Email = request.Email,
                MessageContent = request.MessageContent,
                Subject = request.Subject,
                NameSurname= request.NameSurname,
            });
        }
    }
}
