using System;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.ViewModel
{
    public class CartViewModel : ICart
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrice { get; set; }
        public ISession Session { get; set; } 
        public string Promocode { get; set; }
    }
}
