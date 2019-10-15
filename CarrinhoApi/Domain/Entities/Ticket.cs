using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using CarrinhoApi.Domain.Entities.Enums;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.Domain.Entities
{
    public class Ticket : ITicket
    {
        //[BsonElement("Id")]
        //[JsonProperty("Id")]
        public int IdTicket { get; set; }

        //[BsonElement("Name")]
        //[JsonProperty("Name")]
        public TicketType TicketType { get; set; }

        //[BsonElement("Price")]
        //[JsonProperty("Price")]
        public double Price { get; set; }
    }
}
