using Microsoft.EntityFrameworkCore;
using SJwtCase.Message.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Message.Persistence.Context
{
    public class MessageContext : DbContext
    {
        public MessageContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UserMessage> UserMessages { get; set; }
    }
}
