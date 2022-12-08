using AutoMapper;
using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Modelos.FabricantesViewModel;
using CadastroDeProdutos.Modelos.Produtos;
using CadastroDeProdutos.Modelos.ProdutosViewModel;

namespace CadastroDeProdutos.AutoMapper
{
	public class AutoMapper :Profile
	{
		public AutoMapper()
		{
			// Mapper Produtos
			CreateMap<CadastrarProdutoView,Produto>();
			// Mapper Fabricante
			CreateMap<CadastrarFabricanteView,Fabricante>();
			CreateMap<Fabricante,CadastrarFabricanteView>();
			CreateMap<CadastrarFabricanteView,BuscarFabricantesView>();
		}
	}
}
