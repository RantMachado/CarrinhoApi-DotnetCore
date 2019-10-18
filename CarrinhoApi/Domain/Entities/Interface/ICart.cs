using System;

namespace CarrinhoApi.Domain.Entities.Interface
{
    public interface ICart
    {
        string Id { get; set; }
        DateTime Date { get; set; }
        double TotalPrice { get; set; }
        Sessions Session { get; set; }
        string Promocode { get; set; }
    }
}
