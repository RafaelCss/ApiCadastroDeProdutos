using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Dominio.Interface.Generica;
using CadastroDeProdutos.Dominio.Interface.IFabricantes;
using CadastroDeProdutos.Dominio.Repositorio;
using CadastroDeProdutos.Infra;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeProdutos.Dominio.Servicos.ServicosFabricantes
{
	public class ServicosFabricantes : Repositorio<Fabricante>, IServicosFabricantes
	{
		public ServicosFabricantes(ContextoDb contextoDb) : base(contextoDb)
		{
		}

		public async Task<bool> AdicionarFabricante(Fabricante request)
		{
			var fabricante =  new Fabricante(request.Categoria,request.Nome);
			await Adcionar(fabricante);
			return true;
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
