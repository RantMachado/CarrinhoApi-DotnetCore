using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarrinhoApi.Domain.Entities
{
    public class Cart
    {
        //Atributes
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Date")]
        public DateTime Date { get; set; }

        [BsonElement("TotalPrice")]
        public double TotalPrice { get; set; }

        [BsonElement("Sessions")]
        public List<Session> Sessions { get; set; }

        [BsonElement("Promocode")]
        public string Promocode { get; set; }
    }
}
