

using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Dominio.Interface.Generica;

namespace CadastroDeProdutos.Dominio.Interface.IServicoProdutos
{
    public interface IServicoProdutos : IRepositorio<Produto>
    {
        public Task CadastarProduto(string nome , decimal preco, Guid fornecedor);
		public Task ModificarProduto(Guid id,string nome,decimal preco,Guid fornecedor);
	}
}
