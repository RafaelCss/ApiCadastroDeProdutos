

using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroDeProdutos.Dominio.Entidades
{
	public class Fabricante
	{

		public Fabricante(string categoria,string nome)
		{
			ValidarNome(nome);
			ValidarCategoria(categoria);
		}
		public Fabricante(){}

		public Guid Id { get; set; }
		public string Nome { get; set; }
		public string Categoria { get; set; }
		[NotMapped]
		public List<Produto> Produtos { get; set; }


		public void ValidarNome(string nome)
		{
			if(!String.IsNullOrEmpty(nome))
			Nome = nome;
		}

		public void ValidarCategoria(string categoria)
		{
			if(!String.IsNullOrEmpty(categoria))
			Categoria = categoria;
		}


	}
}
