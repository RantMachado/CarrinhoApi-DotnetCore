using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.Domain.Entities
{
    public class Event : IEvent
    {
        [BsonElement("Id")]
        [JsonProperty("Id")]
        public int IdEvent { get; set; }

        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string NameEvent { get; set; }
    }
}
