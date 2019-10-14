using System;

namespace CarrinhoApi.Domain.Entities.Interface
{
    public interface ICart
    {
        Guid Id { get; set; }
        DateTime Date { get; set; }
        double TotalPrice { get; set; }
        ISession Session { get; set; }
        string Promocode { get; set; }
    }
}
