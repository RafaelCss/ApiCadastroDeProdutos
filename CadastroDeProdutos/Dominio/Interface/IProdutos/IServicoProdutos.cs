

using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Dominio.Interface.Generica;

namespace CadastroDeProdutos.Dominio.Interface.IServicoProdutos
{
    public interface IServicoProdutos : IGenerica<Produto>
    {
		Task<bool> AdicionarProduto(Produto fabricante);
		Task ModificarProduto(Guid id,string nome,string preco);
		Task<List<Produto>> BuscarProduto(Guid id,string nome);
	}
}
