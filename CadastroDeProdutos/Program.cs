using CadastroDeProdutos.Dominio.Interface;
using CadastroDeProdutos.Dominio.Interface.IServicoProdutos;
using CadastroDeProdutos.Dominio.Servicos.ServicoProdutos;
using CadastroDeProdutos.Infra;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ContextoDb>(opt =>
	opt.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoBD")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<IServicoProdutos,ServicoProduto>();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
