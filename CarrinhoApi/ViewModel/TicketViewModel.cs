using CarrinhoApi.Domain.Entities.Enums;

namespace CarrinhoApi.ViewModel
{
    public class TicketViewModel
    {
        public int IdTicket { get; set; }
        public TicketType TicketType { get; set; }
        public double Price { get; set; }
    }
}
