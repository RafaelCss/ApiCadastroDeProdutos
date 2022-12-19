using CadastroDeProdutos.Dominio.Interface.Generica;
using CadastroDeProdutos.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace CadastroDeProdutos.Dominio.Repositorio
{
	public class Repositorio<T> : IGenerica<T>, IDisposable where T : class
	{
		private readonly ContextoDb _contextoDb;

		public Repositorio(ContextoDb contextoDb)
		{
			_contextoDb = contextoDb ;
		}

		protected DbSet<T> Entidade
		{
			get{ return _contextoDb.Set<T>();}
		}


		#region //Adicionar  
		public async Task Adcionar(T obj)
		{
			await Entidade.AddAsync(obj);
			 Salvar();
		
		}
		#endregion


		public Task Atualizar(T obj,Guid id)
		{
			throw new NotImplementedException();
		}

		public Task BuscarPorId(Guid id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<T>> BuscarTodos()
		{
			return await Entidade.ToListAsync();
		}

		public Task<bool> Deletar(Guid id)
		{
			throw new NotImplementedException();
		}

		private void Salvar()
		{
			_contextoDb.SaveChangesAsync();
		}

		#region // configurando Dipose 

		private bool _disposedValue;
		// Instantiate a SafeHandle instance.
		private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero,true);
		// Public implementation of Dispose pattern callable by consumers.
		public void Dispose() => Dispose(true);
		// Protected implementation of Dispose pattern.
		protected virtual void Dispose(bool disposing)
		{
			if(!_disposedValue)
			{
				if(disposing)
				{
					_safeHandle.Dispose();
				}

				_disposedValue = true;
			}
		}

		#endregion
	}
}
