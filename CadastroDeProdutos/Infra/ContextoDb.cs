﻿using CadastroDeProdutos.Dominio.Entidades;
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
			modelBuilder.ApplyConfiguration<Produto>(new MapProduto());
			modelBuilder.ApplyConfiguration<Fabricante>(new MapFabricante());

			base.OnModelCreating(modelBuilder);
		}
	}
}
