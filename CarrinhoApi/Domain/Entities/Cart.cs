using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.Domain.Entities
{
    public class Cart : ICart
    {
        //Atributes
        [BsonId]        
        public Guid Id { get; set; }

        [BsonElement("Date")]
        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        [BsonElement("TotalPrice")]
        [JsonProperty("TotalPrice")]
        public double TotalPrice { get; set; }

        [BsonElement("Sessions")]
        [JsonProperty("Sessions")]
        public ISession Session { get; set; }

        [BsonElement("Promocode")]
        [JsonProperty("Promocode")]
        public string Promocode { get; set; }

        //I know u love constructs
        public Cart(ICart cartVM) // Construtor da CartVieModel
        {
            Id = Guid.NewGuid();
            Date = DateTime.Now;
            Session = cartVM.Session;
            TotalPrice = cartVM.TotalPrice;            
            Promocode = cartVM.Promocode;
        }

        public Cart(Guid id,ICart cartVM) // Construtor da CartVieModel
        {
            Id = Guid.NewGuid();
            Date = DateTime.Now;
            Session = cartVM.Session;
            TotalPrice = cartVM.TotalPrice;
            Promocode = cartVM.Promocode;
        }

        public Cart(Guid id, DateTime date, double totalPrice, Session session, string promocode)
        {
            Id = id;
            Date = date;
            TotalPrice = totalPrice;
            Session = session;
            Promocode = promocode;
        }
    }
}