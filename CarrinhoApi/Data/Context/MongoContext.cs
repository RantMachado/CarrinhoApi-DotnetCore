using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using CarrinhoApi.Domain.Entities;
using CarrinhoApi.Data.CartSettings;
using CarrinhoApi.Data.CartSettings.Interfaces;
using CarrinhoApi.Data.Context.Interfaces;

namespace CarrinhoApi.Data.Context
{
    public class MongoContext : IMongoContext
    {
        private IMongoDatabase MongoDatabase { get; set; }
        public IClientSessionHandle ClientSession { get; set; }
        public MongoClient MongoClient { get; set; }
        private readonly List<Func<Task>> _commands;
        private readonly IConfiguration _configuration;        
        
        //Oohhh Yeah here we go again, another construct... 
        public MongoContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _commands = new List<Func<Task>>();            
        }
        
        //More Methods;
        public async Task<int> SaveChanges()
        {
            ConfigureMongo();
        
            using (ClientSession = await MongoClient.StartSessionAsync())
            {
                ClientSession.StartTransaction();
        
                var commandTasks = _commands.Select(c => c());
        
                await Task.WhenAll(commandTasks);
        
                await ClientSession.CommitTransactionAsync();
            }
        
            return _commands.Count;
        }
        
        private void ConfigureMongo()
        {
            if (MongoClient != null)
                return;
        
            MongoClient = new MongoClient(_configuration["CartDatabaseSettings:ConnectionString"]);
            MongoDatabase = MongoClient.GetDatabase(_configuration["CartDatabaseSettings:DatabaseName"]);
        }
        
        public IMongoCollection<T> GetCollection<T>(string name)
        {
            ConfigureMongo();            
            return MongoDatabase.GetCollection<T>(name);
        }
        
        public void Dispose()
        {
            ClientSession?.Dispose();
            GC.SuppressFinalize(this);
        }
        
        public void AddCommand(Func<Task> func)
        {
            _commands.Add(func);
        }
    }
}
