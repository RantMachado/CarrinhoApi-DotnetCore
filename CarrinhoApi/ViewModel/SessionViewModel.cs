using System;
using System.Collections.Generic;

namespace CarrinhoApi.ViewModel
{
    public class SessionViewModel
    {
        public EventViewModel Event { get; set; }
        public DateTime Date { get; set; }
        public TheatreViewModel Theatre { get; set; }
        public List<TicketViewModel> ListTickets { get; set; }
    }
}
