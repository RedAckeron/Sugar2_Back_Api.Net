using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.Data.SqlClient;
using System.Data;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDbConnection>(sp => new SqlConnection(configuration.GetConnectionString("default")));

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepo, UserRepo>();

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();

builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<IItemRepo, ItemRepo>();

builder.Services.AddScoped<ICmdService, CmdService>();
builder.Services.AddScoped<ICmdRepo,CmdRepo>();

builder.Services.AddScoped<ICustomerAdresseRepo, CustomerAdresseRepo>();

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
