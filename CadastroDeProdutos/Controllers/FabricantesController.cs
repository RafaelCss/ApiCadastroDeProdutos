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
		public ActionResult<List<Fabricante>> BuscarFabricantes()
		{
			var resultado = _servicoFabricantes.BuscarTodos();
			return Ok(resultado);
		}

		[HttpPost]
		public ActionResult CadastrarFabricante([FromBody] CadastrarFabricanteView fabricante)
		{
			var mapperFabricante = _mapper.Map<Fabricante>(fabricante);
			var resultado = _servicoFabricantes.Adcionar(mapperFabricante);
			return Ok(resultado);
		}
	}
}
