
using CadastroDeProdutos.Dominio.Entidades;
using CadastroDeProdutos.Dominio.Interface.Generica;


namespace CadastroDeProdutos.Dominio.Interface.IFabricantes
{
	public interface IServicosFabricantes : IRepositorio<Fabricante>								
	{
		Task AdicionarFabricante(Fabricante fabricante);
		Task ModificarFabricante(Guid id , string nome , string categoria);
		Task<List<Fabricante>> BuscarFabricante(Guid id,string nome,string categoria);
	}
}
