using AutoMapper;
using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Dominio.Interface.IServicoProdutos;
using CadastroDeProdutos.Dominio.Repositorio;
using CadastroDeProdutos.Infra;
using CadastroDeProdutos.Modelos.Produtos;

namespace CadastroDeProdutos.Dominio.Servicos.ServicoProdutos
{
	public class ServicoProduto : Repositorio<Produto>, IServicoProdutos
	{
		private readonly ContextoDb _contextoDb;

		public ServicoProduto(ContextoDb contextoDb) : base(contextoDb)
		{
			_contextoDb= contextoDb;
		}

		public async Task CadastarProduto(string nome,decimal preco,Guid fornecedor)
		{
			var produto = new Produto(nome, preco, fornecedor);
			await Adcionar(produto);
		}

		public Task ModificarProduto(Guid id,string nome,decimal preco,Guid fornecedor)
		{
			throw new NotImplementedException();
		}
	}




}
