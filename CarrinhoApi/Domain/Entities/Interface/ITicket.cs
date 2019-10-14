using CarrinhoApi.Domain.Entities.Enums;

namespace CarrinhoApi.Domain.Entities.Interface
{
    public interface ITicket
    {
        int IdTicket { get; set; }
        TicketType TicketType { get; set; }
        double Price { get; set; }
    }
}
