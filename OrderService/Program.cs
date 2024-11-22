using OrderService.Repositories;
using OrderService.Services;
using OrderService.Data;
using Microsoft.EntityFrameworkCore;
using Shared.Models;
using Shared.DTOs;

var builder = WebApplication.CreateBuilder(args);

// Adicionando serviços necessários
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionando o HttpClient para comunicação entre os serviços
builder.Services.AddHttpClient();

// Adicionando AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Registrando repositórios
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

// Registrando os serviços
builder.Services.AddScoped<IOrderService, OrderService.Services.OrderService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();


var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
