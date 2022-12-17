using System.ComponentModel.DataAnnotations;

namespace CadastroDeProdutos.Modelos.Produtos
{
	public class CadastrarProdutoView
	{
		[Display(Name = "Nome Produto")]
		public string Nome { get; set; }
		[Display(Name = "Preço")]
		public decimal Preco { get; set; }
		[Display(Name = "Fabricante")]
		public Guid Fabricante { get; set; }
	}

}
