using MediatR;
using SJwtCase.Message.Application.Features.Mediator.Queries;
using SJwtCase.Message.Application.Features.Mediator.Result;
using SJwtCase.Message.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Message.Application.Features.Mediator.Handlers
{
    public class GetMessageByIdHandler : IRequestHandler<GetMessageByIdQuery, GetMessageByIdQueryResult>
    {
        private readonly IMessageService _messageService;

        public GetMessageByIdHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<GetMessageByIdQueryResult> Handle(GetMessageByIdQuery request, CancellationToken cancellationToken)
        {
            var value =await  _messageService.GetMessageById(request.Id);
            return new GetMessageByIdQueryResult
            {
                 Email = value.Email,
                 Subject = value.Subject,
                 MessageContent = value.MessageContent,
                 NameSurname=value.NameSurname,
                 UserMessageID = value.UserMessageID
            };
          

        }
    }
}
