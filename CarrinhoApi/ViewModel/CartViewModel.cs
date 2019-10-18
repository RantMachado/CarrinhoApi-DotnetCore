using System;
using CarrinhoApi.Domain.Entities;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.ViewModel
{
    public class CartViewModel : ICart
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrice { get; set; }
        public Sessions Session { get; set; } 
        public string Promocode { get; set; }
    }
}
