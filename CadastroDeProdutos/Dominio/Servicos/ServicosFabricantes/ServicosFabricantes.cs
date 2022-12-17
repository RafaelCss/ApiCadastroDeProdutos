using AutoMapper;
using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Dominio.Interface.IFabricantes;
using CadastroDeProdutos.Dominio.Repositorio;
using CadastroDeProdutos.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CadastroDeProdutos.Dominio.Servicos.ServicosFabricantes
{
	public class ServicosFabricantes : Repositorio<Fabricante>, IServicosFabricantes
	{
		private readonly DbContextOptions<ContextoDb> _contextoDb;

		public ServicosFabricantes() 
		{
			_contextoDb = new DbContextOptions<ContextoDb>();
		}

		public async Task AdicionarFabricante(Fabricante request)
		{
			var fabricante = new Fabricante(request.Categoria,request.Nome);

			using(var data = new ContextoDb(_contextoDb))
			{
				if(fabricante != null)
					await data.Set<Fabricante>().AddAsync(fabricante);	
					await data.SaveChangesAsync();
			}
		}

		public Task<List<Fabricante>> BuscarFabricante(Guid id,string nome,string categoria)
		{
			throw new NotImplementedException();
		}

		public Task ModificarFabricante(Guid id,string nome,string categoria)
		{
			throw new NotImplementedException();
		}
	}
}
