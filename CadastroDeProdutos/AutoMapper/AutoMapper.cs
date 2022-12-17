using AutoMapper;
using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Modelos.FabricantesViewModel;
using CadastroDeProdutos.Modelos.Produtos;

namespace CadastroDeProdutos.AutoMapper
{
	public class AutoMapper :Profile
	{
		public AutoMapper()
		{
			// Mapeando os Produtos
			CreateMap<CadastrarProdutoView,Produto>();
			CreateMap<Produto,CadastrarProdutoView>();
			// Mapeando os Fabricante
			CreateMap<CadastrarFabricanteView,Fabricante>();
			CreateMap<Fabricante,CadastrarFabricanteView>();

		}
	}
}
