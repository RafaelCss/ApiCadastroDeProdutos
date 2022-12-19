
using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Dominio.Interface.IServicoProdutos;
using CadastroDeProdutos.Dominio.Repositorio;
using CadastroDeProdutos.Infra;

namespace CadastroDeProdutos.Dominio.Servicos.ServicoProdutos
{
	public class ServicoProduto : Repositorio<Produto>, IServicoProdutos
	{
		public ServicoProduto(ContextoDb contextoDb) : base(contextoDb)
		{

		}

		public async Task<bool> AdicionarProduto(Produto produto)
		{
			await Adcionar(produto);
			return true;
		}

		public Task<List<Produto>> BuscarProduto(Guid id,string nome)
		{
			throw new NotImplementedException();
		}

		public Task ModificarProduto(Guid id,string nome,string preco)
		{
			throw new NotImplementedException();
		}
	}




}
