using OrderService.Repositories;
using OrderService.Services;
using OrderService.Data;
using Microsoft.EntityFrameworkCore;
using Shared.Models;
using Shared.DTOs;

var builder = WebApplication.CreateBuilder(args);

// Adicionando servi�os necess�rios
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionando o HttpClient para comunica��o entre os servi�os
builder.Services.AddHttpClient();

// Adicionando AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Registrando reposit�rios
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

// Registrando os servi�os
builder.Services.AddScoped<IOrderService, OrderService.Services.OrderService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();


var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
