namespace CadastroDeProdutos.Dominio.Interface.Generica
{
    public interface IRepositorio<T> where T : class
    {
        Task BuscarPorId(Guid id);
        Task<List<T>> BuscarTodos();
        Task Adcionar(T obj);
        Task Atualizar(T obj, Guid id);
        Task<bool> Deletar(Guid id);
    }
}
