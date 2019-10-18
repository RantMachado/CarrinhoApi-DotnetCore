using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization;
using CarrinhoApi.Domain.Entities;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.Persistence
{
    public class CartMap
    {
        public static void Configure()
        {            
            BsonClassMap.RegisterClassMap<Cart>(map =>
            {
                map.AutoMap();
                map.SetIsRootClass(true);
                map.SetIgnoreExtraElements(true);
                map.SetIdMember(map.GetMemberMap( c => c.Id ));
                map.MapIdProperty(c => c.Id);                
                map.MapProperty(c => c.Date).ApplyDefaultValue(DateTime.Now);
                map.MapProperty(c => c.TotalPrice);
                map.MapProperty(c => c.Session);
                map.MapProperty(c => c.Promocode);
            });

            BsonClassMap.RegisterClassMap<Sessions>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapProperty(s => s.Event);
                map.MapProperty(s => s.Date);
                map.MapProperty(s => s.Theatre);
                map.MapProperty(s => s.Tickets);
            });

            BsonClassMap.RegisterClassMap<Event>(map => 
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapProperty(e => e.Id);
                map.MapProperty(e => e.Name);
            });

            BsonClassMap.RegisterClassMap<Theatre>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapProperty(th => th.Id);
                map.MapProperty(th => th.Name);
            });

            BsonClassMap.RegisterClassMap<Ticket>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapProperty( ti => ti.Id);
                map.MapProperty( ti => ti.Name);
                map.MapProperty( ti => ti.Price);
            });
        }
    }
}
