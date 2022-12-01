namespace CadastroDeProdutos.Dominio.Interface.Generica
{
    public interface IServico<T> where T : class
    {
        Task<T> BuscarPorId(Guid id);
        Task<List<T>> BuscarTodos();
        Task<T> Adcionar(T obj);
        Task<T> Atualizar(T obj, Guid id);
        Task<bool> Deletar(Guid id);
    }
}
