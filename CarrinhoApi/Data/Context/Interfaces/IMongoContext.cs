using System;
using System.Threading.Tasks;
using MongoDB.Driver;
using CarrinhoApi.Domain.Entities;

namespace CarrinhoApi.Data.Context.Interfaces
{
    public interface IMongoContext
    {
        void AddCommand(Func<Task> func);
        Task<int> SaveChanges();
        IMongoCollection<TEntity> GetCollection<TEntity>(string name);
        void Dispose();
    }
}
