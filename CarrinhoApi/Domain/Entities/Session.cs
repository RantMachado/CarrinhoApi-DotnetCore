using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.Domain.Entities
{
    public class Session : ISession
    {
        //[BsonElement("Event")]
        //[JsonProperty("Event")]
        public IEvent Event { get; set; }

        //[BsonElement("Date")]
        //[JsonProperty("Date")]
        public DateTime Date { get; set; }

        //[BsonElement("Theatre")]
        //[JsonProperty("Theatre")]
        public ITheatre Theatre { get; set; }

        //[BsonElement("Tickets")]
        //[JsonProperty("Tickets")]
        public List<ITicket> ListTickets { get; set; }
    }
}
