using System;
using MongoDB.Bson.Serialization;
using CarrinhoApi.Domain.Entities;

namespace CarrinhoApi.Persistence
{
    public class CartMap
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<Cart>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
                map.SetIdMember(map.GetMemberMap(x => x.Id));
                map.MapMember(x => x.Date).ApplyDefaultValue(DateTime.Now);
                map.MapMember(x => x.TotalPrice).SetIsRequired(true);
                map.MapMember(x => x.Session).SetIsRequired(true);
                //map.MapMember(x => x.Session.Event).SetIsRequired(true);
                //map.MapMember(x => x.Session.Event.IdEvent);
                //map.MapMember(x => x.Session.Event.NameEvent);
                //map.MapMember(x => x.Session.Date);
                //map.MapMember(x => x.Session.Theatre).SetIsRequired(true); ;
                //map.MapMember(x => x.Session.Theatre.IdTheatre);
                //map.MapMember(x => x.Session.Theatre.NameTheatre);
                //map.MapMember(x => x.Session.ListTickets).SetIsRequired(true);                
                map.MapMember(x => x.Promocode).SetIsRequired(true);
            });
        }
    }
}
