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
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
                map.SetIdMember(map.GetMemberMap(x => x.Id));
                map.MapMember(x => x.Date).ApplyDefaultValue(DateTime.Now);
                map.MapMember(x => x.TotalPrice);
                map.MapMember(x => x.Session);
                map.MapMember(x => x.Promocode);
            });
        }
    }
}
