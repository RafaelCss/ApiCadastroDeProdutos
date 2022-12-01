namespace CadastroDeProdutos.Dominio.Entidades
{
	public class Fabricante
	{
		public Guid Id { get; set; }
		public string Nome { get; set; }
		public string Categoria { get; set; }
		public List<Produto> Produtos { get; set; } 
	}
}
