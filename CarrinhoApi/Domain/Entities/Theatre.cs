using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.Domain.Entities
{
    public class Theatre : ITheatre
    {
        //[BsonElement("Id")]
        //[JsonProperty("Id")]
        public int IdTheatre { get; set; }

        //[BsonElement("Name")]
        //[JsonProperty("Name")]
        public string NameTheatre { get; set; }
    }
}
