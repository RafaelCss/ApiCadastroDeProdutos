using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Dominio.Interface.IServicoProdutos;
using CadastroDeProdutos.Infra;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeProdutos.Dominio.Servicos.ServicoProdutos
{
    public class ServicoProduto : IServicoProdutos
	{
		private readonly ContextoDb _contextoDb;

		public ServicoProduto(ContextoDb contextoDb)
		{
			_contextoDb = contextoDb;
		}

		public async Task<Produto> BuscarPorId(Guid id)
		{
			return await _contextoDb.Produtos.FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task<Produto> Adcionar(Produto obj)
		{
			var resultado = await _contextoDb.AddAsync(obj);
				await _contextoDb.SaveChangesAsync();
			return obj;
		}

		public async Task<Produto> Atualizar(Produto obj,Guid id)
		{
			var produto = await BuscarPorId(id);
			if (produto == null)
			{
				throw new Exception("Produto não encontrado"); 
			}
			//var resultado = await _contextoDb.Update(produto);
			await _contextoDb.SaveChangesAsync();

			return produto;
		}


		public async Task<List<Produto>> BuscarTodos() 
		{
			return  await _contextoDb.Produtos.ToListAsync();
		}

		public async Task<bool> Deletar(Guid id)
		{
			var produto = await BuscarPorId(id);
			if(produto == null)
			{
				throw new Exception("Produto não encontrado");
			}
			_contextoDb.Produtos.Remove(produto);
			await _contextoDb.SaveChangesAsync();

			return true;

		}
	}
}
