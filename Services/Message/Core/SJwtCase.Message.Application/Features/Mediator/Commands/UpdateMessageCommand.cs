﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Message.Application.Features.Mediator.Commands
{
    public class UpdateMessageCommand : IRequest
    {
        public int UserMessageID { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
    }
}
