using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.Domain.Entities
{
    public class Sessions : ISession
    {
        [BsonElement("Event")]
        [JsonProperty("Event")]
        public IEvent Event { get; set; }

        [BsonElement("Date")]
        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        [BsonElement("Theatre")]
        [JsonProperty("Theatre")]
        public ITheatre Theatre { get; set; }

        [BsonElement("Tickets")]
        [JsonProperty("Tickets")]
        public ITicket[] Tickets { get; set; }
    }
}
