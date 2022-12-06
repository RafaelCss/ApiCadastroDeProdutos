using AutoMapper;
using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Dominio.Interface.IServicoProdutos;
using CadastroDeProdutos.Dominio.Servicos.ServicoProdutos;
using CadastroDeProdutos.Modelos.Produtos;
using CadastroDeProdutos.Modelos.ProdutosViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeProdutos.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProdutoController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IServicoProdutos _servicoProduto;
		public ProdutoController(IMapper mapper,IServicoProdutos servicoProduto)
		{
			_mapper = mapper;
			_servicoProduto = servicoProduto;
		}

		[HttpGet]
		public ActionResult<List<BuscarProdutoView>> BuscarProdutos()
		{
			var resultado = _servicoProduto.BuscarTodos();
			return Ok(resultado);
		}


		[HttpPost]
		public ActionResult<CadastrarProdutoView> CadastrarProduto([FromBody] CadastrarProdutoView produtoView)
		{
			var produto = _mapper.Map<Produto>(produtoView);
			var resultado = _servicoProduto.Adcionar(produto);
			return Ok(resultado);
		}


		[HttpGet("{id}")]
		public ActionResult<BuscarProdutoView> BuscarProdutoPorId(Guid id)
		{
			var resultado = _servicoProduto.BuscarPorId(id);
			return Ok(resultado);
		}
	}
}
