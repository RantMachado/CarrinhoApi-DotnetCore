﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarrinhoApi.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> GetAll();
        void Update(TEntity obj);
        void Remove(Guid id);        
    }
}
