﻿using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarrinhoApi.Domain.Entities
{
    public class Session 
    {
        [BsonElement("Event")]
        public Event Event { get; set; }

        [BsonElement("Date")]
        public DateTime Date { get; set; }

        [BsonElement("Theatre")]
        public Theatre Theatre { get; set; }

        [BsonElement("Tickets")]
        public List<Ticket> ListTickets { get; set; }
    }
}
