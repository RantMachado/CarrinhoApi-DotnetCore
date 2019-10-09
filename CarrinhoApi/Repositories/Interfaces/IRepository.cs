﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarrinhoApi.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        void Update(TEntity obj);
        void Remove(Guid id);
        void Disposable();
    }
}