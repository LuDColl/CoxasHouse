using Infraestructure;
using Infraestructure.Repository;
using Infraestructure.Repository.Interfaces;
using Infraestructure.UnitOfWork;
using Infraestructure.UnitOfWork.Interfaces;
using Microsoft.EntityFrameworkCore;
using Services;
using Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CoxaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPessoaService, PessoaService>();
builder.Services.AddScoped<IPessoaUnitOfWork, PessoaUnitOfWork>();
builder.Services.AddScoped<IPessoaRepository, PessoaRepository>();

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
