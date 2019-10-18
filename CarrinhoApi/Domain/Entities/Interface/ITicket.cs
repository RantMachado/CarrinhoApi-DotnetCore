using CarrinhoApi.Domain.Entities.Enums;

namespace CarrinhoApi.Domain.Entities.Interface
{
    public interface ITicket
    {
        int Id { get; set; }
        TicketType Name { get; set; }
        double Price { get; set; }
    }
}
