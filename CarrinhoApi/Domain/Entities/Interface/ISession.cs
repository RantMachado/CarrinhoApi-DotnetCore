using System;
using System.Collections.Generic;

namespace CarrinhoApi.Domain.Entities.Interface
{
    public interface ISession
    {
        IEvent Event { get; set; }
        DateTime Date { get; set; }
        ITheatre Theatre { get; set; }
        List<ITicket> ListTickets { get; set; }
    }
}
