using CadastroDeProdutos.Dominio.Interface;
using CadastroDeProdutos.Dominio.Interface.Generica;
using CadastroDeProdutos.Dominio.Interface.IFabricantes;
using CadastroDeProdutos.Dominio.Interface.IServicoProdutos;
using CadastroDeProdutos.Dominio.Repositorio;
using CadastroDeProdutos.Dominio.Servicos.ServicoProdutos;
using CadastroDeProdutos.Dominio.Servicos.ServicosFabricantes;
using CadastroDeProdutos.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var connectioDataBase = builder.Configuration.GetConnectionString("connectionMysql");
builder.Services.AddDbContext<ContextoDb>(opt =>
	opt.UseMySql(connectioDataBase,ServerVersion.AutoDetect(connectioDataBase)));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IServicoProdutos,ServicoProduto>();
builder.Services.AddScoped<IServicosFabricantes,ServicosFabricantes>();
builder.Services.AddScoped(typeof(IGenerica<>), typeof(Repositorio<>));
//
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
