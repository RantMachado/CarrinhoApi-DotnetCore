﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using ServiceStack;
using CarrinhoApi.Data.Interfaces;

namespace CarrinhoApi.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //Atributes
        protected readonly IMongoContext _context;
        protected IMongoCollection<TEntity> DbSet;

        //Construct 
        protected BaseRepository(IMongoContext context)
        {
            _context = context;
        }

        //Methods of BaseRepository
        public virtual void Add(TEntity obj)
        {
            ConfigDbSet();
            _context.AddComand(() => DbSet.InsertOneAsync(obj));

        }

        private void ConfigDbSet()
        {
            DbSet = _context.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            ConfigDbSet();
            var data = await DbSet.FindAsync(Builders<TEntity>.Filter.Eq("_id", id ));
            return data.SingleOrDefault();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            ConfigDbSet();
            var all = await DbSet.FindAsync(Builders<TEntity>.Filter.Empty);
            return all.ToList();
        }

        public virtual void Update(TEntity obj)
        {
            ConfigDbSet();
            _context.AddComand(() => DbSet.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("_id", obj.GetId()), obj));
        }

        public virtual void Remove(Guid id)
        {
            ConfigDbSet();
            _context.AddComand(() => DbSet.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", id)));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Disposable()
        {
            throw new NotImplementedException();
        }
    }
}