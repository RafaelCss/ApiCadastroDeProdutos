using CadastroDeProdutos.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroDeProdutos.Infra.Mapeamento
{
	public class MapFabricante : IEntityTypeConfiguration<Fabricante>
	{
		public void Configure(EntityTypeBuilder<Fabricante> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Nome).IsRequired();

		}
	}
}
