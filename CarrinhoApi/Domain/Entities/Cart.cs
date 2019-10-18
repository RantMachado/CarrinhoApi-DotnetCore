using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.Domain.Entities
{
        public class Cart : ICart
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            [JsonProperty("_id")]
            public string Id { get; set; }
            
            [JsonProperty("Date")]
            public DateTime Date { get; set; }

            [JsonProperty("TotalPrice")]
            public Double TotalPrice { get; set; }

            [JsonProperty("Session")]
            public Sessions Session { get; set; }

            [JsonProperty("PromoCode")]
            public string Promocode { get; set; }

            //I know u love constructs
            public Cart(ICart cartVM) // Construtor da CartVieModel
            {
                Id = cartVM.Id;
                Date = DateTime.Now;
                Session = cartVM.Session;
                TotalPrice = cartVM.TotalPrice;
                Promocode = cartVM.Promocode;
            }

            //public Cart(Guid id, ICart cartVM) // Construtor da CartVieModel
            //{
            //    Id = Guid.NewGuid();
            //    Date = DateTime.Now;
            //    Session = cartVM.Session;
            //    TotalPrice = cartVM.TotalPrice;
            //    Promocode = cartVM.Promocode;
            //}

            public Cart(string id, DateTime date, double totalPrice, Sessions session, string promocode)
            {
                Id = id;
                Date = date;
                TotalPrice = totalPrice;
                Session = session;
                Promocode = promocode;
            }
        }
        /*
        public class Sessions
        {
            public Event Event { get; set; }
            public DateTime Date { get; set; }
            public Theatre Theatre { get; set; }
            public Ticket[] Tickets { get; set; }
        }

        public class Event
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Theatre
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Ticket
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
        }*/
}