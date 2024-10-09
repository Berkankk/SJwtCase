using Azure.Messaging;
using Microsoft.EntityFrameworkCore;
using SJwtCase.Message.Application.Features.Mediator.Commands;
using SJwtCase.Message.Application.Features.Mediator.Handlers;
using SJwtCase.Message.Application.Interfaces;
using SJwtCase.Message.Persistence.Concrete;
using SJwtCase.Message.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IMessageService ,MessageService>();

//Asembly üzerinden ulaþamadýðý için projeye bu þekilde verdik registýryþýn iþlemini
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblyContaining<CreateMessageCommandHandler>();
});



builder.Services.AddDbContext<MessageContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));//Sql baðlantýmýzý yazdýk burada ,sýrada migration iþlemi var
});



builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
