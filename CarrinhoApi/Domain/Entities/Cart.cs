using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using CarrinhoApi.Domain.Entities.Interface;
using CarrinhoApi.ViewModel;

namespace CarrinhoApi.Domain.Entities
{
        public class Cart : ICart
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
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
            public Cart(CartViewModel cartVM)
            {
                Date = cartVM.Date;
                TotalPrice = cartVM.TotalPrice;
                Session = cartVM.Session;
                Promocode = cartVM.Promocode;
            }
            public Cart(string id, DateTime date, double totalPrice, Sessions session, string promocode)
            {
                Id = id;
                Date = date;
                TotalPrice = totalPrice;
                Session = session;
                Promocode = promocode;
            }
        }
}