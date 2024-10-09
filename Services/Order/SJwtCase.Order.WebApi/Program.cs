using Microsoft.EntityFrameworkCore;
using SJwtCase.Order.BusinessLayer.Abstract;
using SJwtCase.Order.BusinessLayer.Concrete;
using SJwtCase.Order.DataAccessLayer.Abstract;
using SJwtCase.Order.DataAccessLayer.Concrete;
using SJwtCase.Order.DataAccessLayer.Context;
using SJwtCase.Order.DataAccessLayer.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());  //ilgili proje aya�a kalkt���nda profiledan miras alan� g�r diyoruz

builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IOrderingRepository, OrderingRepository>();
builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();  //Bunlar dal da olanlar

builder.Services.AddScoped<IOrderingService, OrderingService>();
builder.Services.AddScoped<IOrderItemService, OrderItemService>();
builder.Services.AddScoped<IAddressService, AddressService>();  //Bunlar business da olanlar 

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<OrderContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));//Sql ba�lant�m�z� yazd�k burada ,s�rada migration i�lemi var
});



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
