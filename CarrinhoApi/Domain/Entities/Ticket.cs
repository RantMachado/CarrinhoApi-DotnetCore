using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using CarrinhoApi.Domain.Entities.Enums;
using CarrinhoApi.ViewModel;

namespace CarrinhoApi.Domain.Entities
{
    public class Ticket
    {
        [BsonElement("Id")]
        public int IdTicket { get; set; }

        [BsonElement("Name")]
        public TicketType TicketType { get; set; }

        [BsonElement("Price")]
        public double Price { get; set; }

        public Ticket(TicketViewModel ticket)
        {
            IdTicket = ticket.IdTicket;
            TicketType = ticket.TicketType;
            Price = ticket.Price;
        }
    }
}
