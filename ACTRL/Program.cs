﻿using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Data;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

IConfiguration configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string databaseAddress=Environment.GetEnvironmentVariable("DB_HOST");

builder.Services.AddSingleton<IDbConnection>(sp => new SqlConnection(configuration.GetConnectionString("default").Replace("[DB_HOST]", databaseAddress)));

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepo, UserRepo>();

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepo, CstRepo>();

builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<IItemRepo, ItemRepo>();

builder.Services.AddScoped<ICmdService, CmdService>();
builder.Services.AddScoped<ICmdRepo,CmdRepo>();

builder.Services.AddScoped<IRprService, RprService>();
builder.Services.AddScoped<IRprRepo, RprRepo>();

builder.Services.AddScoped<IFctService, FctService>();
builder.Services.AddScoped<IFctRepo, FctRepo>();

builder.Services.AddScoped<IOdpService, OdpService>();
builder.Services.AddScoped<IOdpRepo, OdpRepo>();

builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IAddressRepo, AdrRepo>();

builder.Services.AddScoped<IDlcService, DlcService>();
builder.Services.AddScoped<IDlcRepo, DlcRepo>();


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(MyAllowSpecificOrigins);
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
