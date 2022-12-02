using AutoMapper;
using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Modelos.Produtos;

namespace CadastroDeProdutos.AutoMapper
{
	public class AutoMapper :Profile
	{
		public AutoMapper()
		{
			CreateMap<CadastrarProdutoView,Produto>();
		}
	}
}
