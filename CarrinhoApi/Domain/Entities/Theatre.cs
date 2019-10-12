﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using CarrinhoApi.ViewModel;

namespace CarrinhoApi.Domain.Entities
{
    public class Theatre
    {
        [BsonElement("Id")]
        public int IdTheatre { get; set; }

        [BsonElement("Name")]
        public string NameTheatre { get; set; }

        public Theatre(TheatreViewModel theatre)
        {
            IdTheatre = theatre.IdTheatre;
            NameTheatre = theatre.NameTheatre;
        }
    }
}
