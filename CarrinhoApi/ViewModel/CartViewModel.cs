using System;
using CarrinhoApi.Domain.Entities;

namespace CarrinhoApi.ViewModel
{
    public class CartViewModel 
    {        
        public DateTime Date { get; set; }
        public double TotalPrice { get; set; }
        public Sessions Session { get; set; } 
        public string Promocode { get; set; }
        public bool ShouldCommit { get; set; } = true;
    }
}
