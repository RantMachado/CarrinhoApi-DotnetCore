﻿using System;
using System.Collections.Generic;
using CarrinhoApi.Domain.Entities;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.ViewModel
{
    public class SessionViewModel : ISession
    {
        public IEvent Event { get; set; }
        public DateTime Date { get; set; }
        public ITheatre Theatre { get; set; }
        public ITicket[] Tickets { get; set; }
    }
}
