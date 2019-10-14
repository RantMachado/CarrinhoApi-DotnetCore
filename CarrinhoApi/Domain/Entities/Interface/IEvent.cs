using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrinhoApi.Domain.Entities.Interface
{
    public interface IEvent
    {
        int IdEvent { get; set; }
        string NameEvent { get; set; }
    }
}
