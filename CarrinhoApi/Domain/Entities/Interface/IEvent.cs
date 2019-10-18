using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrinhoApi.Domain.Entities.Interface
{
    public interface IEvent
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
