using MediatR;
using SJwtCase.Message.Application.Features.Mediator.Queries;
using SJwtCase.Message.Application.Features.Mediator.Result;
using SJwtCase.Message.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Message.Application.Features.Mediator.Handlers
{
    public class GetMessageQueryHandler : IRequestHandler<GetMessageQuery, List<GetMessageQueryResult>>
    {
        private readonly IMessageService _messageService;

        public GetMessageQueryHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<List<GetMessageQueryResult>> Handle(GetMessageQuery request, CancellationToken cancellationToken)
        {
            var values = await _messageService.GetAllMessages();
            return values.Select(x=> new GetMessageQueryResult
            {
                Email = x.Email,
                MessageContent = x.MessageContent,
                NameSurname=x.NameSurname,
                Subject = x.Subject,
                UserMessageID=x.UserMessageID
            }).ToList();
        }
    }
}
