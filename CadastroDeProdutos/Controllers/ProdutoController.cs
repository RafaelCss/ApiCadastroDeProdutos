using AutoMapper;
using CadastroDeProdutos.Dominio.Servicos.ServicoProdutos;
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
		private readonly ServicoProduto _servicoProduto;
		public ProdutoController(IMapper mapper,ServicoProduto servicoProduto)
		{
			_mapper = mapper;
			_servicoProduto = servicoProduto;
		}

		[HttpGet]
		public ActionResult<List<BuscarProdutoView>> BuscarProdutos()
		{
		//	var maper = _mapper.Map<BuscarProdutoView>(produtos);
			var resultado = _servicoProduto.BuscarTodos();
			return Ok(resultado);
		} 
	}
}
