using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroDeProdutos.Dominio.Entidades
{
	public class Fabricante
	{

		public Fabricante() { }	

		public Guid Id { get; set; }
		public string Nome { get; set; }
		public string Categoria { get; set; }
		[NotMapped]
		public List<Produto> Produtos { get; set; } 
	}
}
