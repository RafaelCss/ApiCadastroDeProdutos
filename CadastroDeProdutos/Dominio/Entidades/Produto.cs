namespace CadastroDeProdutos.Dominio.Entidades
{
	public class Produto
	{
		public Guid Id { get; set; }
		public string Nome { get; set;}
		public virtual Fabricante Fabricante { get; set;}
		public decimal Preco { get; set;}
	}
}
