namespace CadastroDeProdutos.Dominio.Entidades
{
	public class Produto
	{
		public Produto() { }

		public Produto(string nome , decimal preco, Guid fornecedor) 
		{ }

		public Guid Id { get; set; }
		public string Nome { get; set;}
		public decimal Preco { get; set;}
		public  Fabricante Fabricante { get; set;}
	}
}
