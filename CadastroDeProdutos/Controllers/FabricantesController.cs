using AutoMapper;
using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Dominio.Interface.IFabricantes;
using CadastroDeProdutos.Modelos.FabricantesViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeProdutos.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FabricantesController : ControllerBase
	{
		private readonly IServicosFabricantes _servicoFabricantes;
		private readonly IMapper _mapper;
		public FabricantesController(IServicosFabricantes servicoFabricante, IMapper mapper)
		{
			_servicoFabricantes = servicoFabricante;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<ActionResult<List<Fabricante>>> BuscarFabricantes()
		{
			var resultado = await _servicoFabricantes.BuscarTodos();
	
			return Ok(resultado);
		}

		[HttpPost]
		public async Task<IActionResult> CadastrarFabricante([FromBody] CadastrarFabricanteView fabricante)
		{
			// var mapperFabricante =_mapper.Map<CadastrarFabricanteView>(fabricante);
			var resultado = await _servicoFabricantes.Adcionar(fabricante);
			return Ok(resultado);
		}
	}
}
