using CarrinhoApi.Domain.Entities.Enums;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.ViewModel
{
    public class TicketViewModel : ITicket
    {
        public int IdTicket { get; set; }
        public TicketType TicketType { get; set; }
        public double Price { get; set; }
    }
}
