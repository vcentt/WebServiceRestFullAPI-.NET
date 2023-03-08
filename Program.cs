using BackEnd_CSharp.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.IGenericRepository;
using Services;
using Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Settings to connection with database
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddDbContext<NortnotesContext>(op => op.UseNpgsql("name=ConnectionStrings:DefaultConnection"));
builder.Services.AddScoped(typeof(IGenericServices<>), typeof(GenericServices<>));

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
