using CarrinhoApi.Data.CartSettings.Interfaces;

namespace CarrinhoApi.Data.CartSettings
{
    public class CartDatabaseSettings : ICartDatabaseSettings
    {
        public string CartCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
