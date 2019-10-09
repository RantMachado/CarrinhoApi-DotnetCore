using System;
using System.Threading.Tasks;

namespace CarrinhoApi.UoW.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}
