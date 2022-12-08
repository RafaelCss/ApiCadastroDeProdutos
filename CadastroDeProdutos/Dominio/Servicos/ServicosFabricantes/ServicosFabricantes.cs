using AutoMapper;
using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Dominio.Interface.IFabricantes;
using CadastroDeProdutos.Infra;
using CadastroDeProdutos.Modelos.FabricantesViewModel;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeProdutos.Dominio.Servicos.ServicosFabricantes
{
	public class ServicosFabricantes : IServicosFabricantes
	{
		private readonly ContextoDb _contextoDb;
		private readonly IMapper _mapper;

		public ServicosFabricantes(ContextoDb contextoDb, IMapper mapper)
		{
			_contextoDb = contextoDb;
			_mapper = mapper;
		}

		public async Task<CadastrarFabricanteView> Adcionar(CadastrarFabricanteView obj)
		{
			var mapper = _mapper.Map<Fabricante>(obj);
			var cadastro = await _contextoDb.AddAsync(mapper);
				await _contextoDb.SaveChangesAsync();
			var cadastrado = _mapper.Map<CadastrarFabricanteView>(cadastro);
			return cadastrado;
		}

		public Task<CadastrarFabricanteView> Atualizar(CadastrarFabricanteView  obj,Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<CadastrarFabricanteView> BuscarPorId(Guid id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<CadastrarFabricanteView>> BuscarTodos()
		{
			var busca = await _contextoDb.Fabricantes.ToListAsync();
			var mapper = _mapper.Map<List<CadastrarFabricanteView>>(busca);
			return mapper;
		}

		public Task<bool> Deletar(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
