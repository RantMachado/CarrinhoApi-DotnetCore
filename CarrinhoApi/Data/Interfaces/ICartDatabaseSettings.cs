namespace CarrinhoApi.Data.Interfaces
{
    public interface ICartDatabaseSettings
    {
        string CartCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
