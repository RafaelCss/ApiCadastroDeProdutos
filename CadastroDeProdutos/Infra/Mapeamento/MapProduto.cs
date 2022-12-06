using CadastroDeProdutos.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroDeProdutos.Infra.Mapeamento
{
	public class MapProduto : IEntityTypeConfiguration<Produto> 
	{
		public void Configure(EntityTypeBuilder<Produto> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Nome).IsRequired();
			builder.Property(x => x.Preco).IsRequired();
			builder.HasOne(p => p.Fabricante);
		}
	}
}
