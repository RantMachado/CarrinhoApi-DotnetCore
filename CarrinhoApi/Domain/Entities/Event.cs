using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarrinhoApi.Domain.Entities
{
    public class Event
    {
        [BsonElement("Id")]
        public int IdEvent { get; set; }

        [BsonElement("Name")]
        public string NameEvent { get; set; }
    }
}
