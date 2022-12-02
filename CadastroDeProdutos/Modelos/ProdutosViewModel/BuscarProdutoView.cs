using CadastroDeProdutos.Dominio.Entidades;

namespace CadastroDeProdutos.Modelos.ProdutosViewModel
{
	public class BuscarProdutoView
	{
		public Guid Id { get; set; }
		public string Nome { get; set; }
		public decimal Preco { get; set; }
		public BuscarFabricantesLista Fabricante { get; set; }
	}

	public class BuscarFabricantesLista
	{
		public Guid Id { get; set; }
		public string Nome { get; set; }
		public string Categoria { get;}
	}
}
