using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.Domain.Entities
{
    public class Theatre : ITheatre
    {
        [BsonElement("Id")]
        [JsonProperty("Id")]
        public int Id { get; set; }

        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}
