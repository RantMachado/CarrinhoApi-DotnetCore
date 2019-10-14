using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using ServiceStack;
using CarrinhoApi.Domain.Entities;
using CarrinhoApi.Data.Context.Interfaces;

namespace CarrinhoApi.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //Atributes
        protected readonly IMongoContext _context;
        protected IMongoCollection<TEntity> DbSet;

        //Construct 
        protected BaseRepository(IMongoContext context)
        {
            _context = context;            
        }

        public virtual void Add(TEntity obj)
        {
            ConfigDbSet();
            _context.AddCommand(() => DbSet.InsertOneAsync(obj));
        }

        //Methods of BaseRepository
        private void ConfigDbSet()
        {
            DbSet = _context.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            ConfigDbSet();
            var data = await DbSet.FindAsync( Builders<TEntity>.Filter.Eq("_id", id));
            return await data.SingleOrDefaultAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            ConfigDbSet();
            var all = await DbSet.FindAsync(Builders<TEntity>.Filter.Empty);
            return all.ToList();
        }

        public virtual void Update(TEntity obj)
        {
            ConfigDbSet();
            _context.AddCommand(() => DbSet.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("_id", obj.GetId()), obj));
        }

        public virtual void Remove(Guid id)
        {
            ConfigDbSet();
            _context.AddCommand(() => DbSet.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", id)));
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

    }
}
