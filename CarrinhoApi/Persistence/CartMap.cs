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
                map.MapIdMember(c => c.Id);
                map.MapMember(c => c.Date);
                map.MapMember(c => c.TotalPrice);
                map.MapMember(c => c.Session);
                map.MapMember(c => c.Promocode);
            });
        }
    }
}
