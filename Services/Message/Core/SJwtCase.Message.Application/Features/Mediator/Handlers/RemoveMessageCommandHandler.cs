using MediatR;
using SJwtCase.Message.Application.Features.Mediator.Commands;
using SJwtCase.Message.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Message.Application.Features.Mediator.Handlers
{
    public class RemoveMessageCommandHandler : IRequestHandler<RemoveMessageCommand>
    {
        private readonly IMessageService _messageService;

        public RemoveMessageCommandHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task Handle(RemoveMessageCommand request, CancellationToken cancellationToken)
        {
            await _messageService.DeleteMessage(request.Id);

        }
    }
}
