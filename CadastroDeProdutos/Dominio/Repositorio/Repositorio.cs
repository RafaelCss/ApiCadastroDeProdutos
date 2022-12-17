using CadastroDeProdutos.Dominio.Interface.Generica;
using CadastroDeProdutos.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace CadastroDeProdutos.Dominio.Repositorio
{
	public  class  Repositorio<T> : IRepositorio<T>, IDisposable where T : class
	{
		private readonly DbContextOptions<ContextoDb> _contextoDb;

		public Repositorio()
		{
			_contextoDb = new DbContextOptions<ContextoDb>();
		}

		public async Task Adcionar(T obj)
		{
			using(var data = new ContextoDb(_contextoDb))
			{
				await data.Set<T>().AddAsync(obj);	
			}
			
		}

		public Task Atualizar(T obj,Guid id)
		{
			throw new NotImplementedException();
		}

		public Task BuscarPorId(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<List<T>> BuscarTodos()
		{
			throw new NotImplementedException();
		}

		public Task<bool> Deletar(Guid id)
		{
			throw new NotImplementedException();
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
