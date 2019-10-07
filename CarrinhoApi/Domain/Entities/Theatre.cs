using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarrinhoApi.Domain.Entities
{
    public class Theatre
    {
        [BsonElement("Id")]
        public int IdTheatre { get; set; }

        [BsonElement("Name")]
        public string NameTheatre { get; set; }
    }
}
