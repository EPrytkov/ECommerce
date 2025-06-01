using ECommerce.Application;
using ECommerce.Application.Services;
using ECommerce.Application.Services.Interfaces;
using ECommerce.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddApplicationModule();
builder.Services.AddDataModule();

builder.Services.AddDbContext<ECommerceDbContext>(c => 
    c.UseNpgsql(builder.Configuration.GetConnectionString("ECommerce")));

var app = builder.Build();

app.MapControllers();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.Run();