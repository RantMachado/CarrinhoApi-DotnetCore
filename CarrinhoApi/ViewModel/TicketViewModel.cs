using CarrinhoApi.Domain.Entities.Enums;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.ViewModel
{
    public class TicketViewModel : ITicket
    {
        public int Id { get; set; }
        public TicketType Name { get; set; }
        public double Price { get; set; }
    }
}
