using MediatR;
using SJwtCase.Message.Application.Features.Mediator.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Message.Application.Features.Mediator.Queries
{
    public class GetMessageQuery : IRequest<List<GetMessageQueryResult>>
    {
    }
}
