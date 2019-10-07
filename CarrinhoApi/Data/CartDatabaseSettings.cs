using CarrinhoApi.Data.Interfaces;

namespace CarrinhoApi.Data
{
    public class CartDatabaseSettings : ICartDatabaseSettings
    {
        public string CartCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
