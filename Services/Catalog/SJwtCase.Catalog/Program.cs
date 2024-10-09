using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using SJwtCase.Catalog.Context;
using SJwtCase.Catalog.Repositories;
using SJwtCase.Catalog.Services.CategoryServices;
using SJwtCase.Catalog.Services.FeatureServices;
using SJwtCase.Catalog.Services.ProductServices;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly()); //Automapper � ge�tik 
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));  //interface ve onu implemente etti�im s�n�f� yazd�m 
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IFeatureService, FeatureService>();
builder.Services.AddDbContext<CatalogContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));//Sql ba�lant�m�z� yazd�k burada ,s�rada migration i�lemi var
});

//Koruma i�lemi yapt�k burada
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.Authority = builder.Configuration["IdentityServerUrl"];
    opt.Audience = "resource_catalog";
});


builder.Services.AddControllers(opt =>
{
    opt.Filters.Add(new AuthorizeFilter());  //filtreleme ekledik her kontrolera gidip auhorize yazmak yerine buradan verdik direkt
});
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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
