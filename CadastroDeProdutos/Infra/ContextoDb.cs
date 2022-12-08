using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Infra.Mapeamento;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeProdutos.Infra
{
	public class ContextoDb : DbContext
	{
		public ContextoDb(DbContextOptions<ContextoDb> options) : base(options)
		{
		}

		public DbSet<Produto> Produtos { get; set; } 
		public DbSet<Fabricante> Fabricantes { get; set; } 

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new MapProduto());
			modelBuilder.ApplyConfiguration(new MapFabricante());

			base.OnModelCreating(modelBuilder);
		}
	}
}
