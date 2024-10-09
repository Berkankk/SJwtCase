using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Message.Application.Features.Mediator.Commands
{
    public class RemoveMessageCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveMessageCommand(int id)
        {
            Id = id;
        }
    }
}
