using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Dominio.Interface.IFabricantes;
using CadastroDeProdutos.Infra;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeProdutos.Dominio.Servicos.ServicosFabricantes
{
	public class ServicosFabricantes : IServicosFabricantes
	{
		private readonly ContextoDb _contextoDb;

		public ServicosFabricantes(ContextoDb contextoDb)
		{
			_contextoDb = contextoDb;
		}

		public async Task<Fabricante> Adcionar(Fabricante obj)
		{
		     var cadastro = await _contextoDb.AddAsync(obj);
				await _contextoDb.SaveChangesAsync();
			return obj;
		}

		public Task<Fabricante> Atualizar(Fabricante obj,Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<Fabricante> BuscarPorId(Guid id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Fabricante>> BuscarTodos()
		{
			return await _contextoDb.Fabricantes.ToListAsync();
		}

		public Task<bool> Deletar(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
