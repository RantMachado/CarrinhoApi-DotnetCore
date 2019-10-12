using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using CarrinhoApi.ViewModel;

namespace CarrinhoApi.Domain.Entities
{
    public class Cart 
    {
        //Atributes
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }

        [BsonElement("Date")]
        public DateTime Date { get; set; }

        [BsonElement("TotalPrice")]
        public double TotalPrice { get; set; }

        [BsonElement("Sessions")]
        public List<Session> Sessions { get; set; }

        [BsonElement("Promocode")]
        public string Promocode { get; set; }

        //I know u love constructs
        public Cart(CartViewModel cart)
        {
            Id = Guid.NewGuid();
            Date = DateTime.Now;
            TotalPrice = cart.TotalPrice;
            Promocode = cart.Promocode;
        }
        public Cart(CartViewModel cart, Guid id) : this(cart)
        {
            Id = id;
        }
    }
}
