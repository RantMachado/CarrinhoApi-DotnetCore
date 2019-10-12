using System;
using System.Collections.Generic;

namespace CarrinhoApi.ViewModel
{
    public class CartViewModel
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrice { get; set; }
        public List<SessionViewModel> Sessions { get; set; } = new List<SessionViewModel>();
        public string Promocode { get; set; }
    }
}
