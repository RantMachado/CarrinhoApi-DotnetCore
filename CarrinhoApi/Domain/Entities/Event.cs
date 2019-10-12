using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using CarrinhoApi.ViewModel;

namespace CarrinhoApi.Domain.Entities
{
    public class Event
    {
        [BsonElement("Id")]
        public int IdEvent { get; set; }
        [BsonElement("Name")]
        public string NameEvent { get; set; }

        public Event(EventViewModel eventView)
        {
            IdEvent = eventView.IdEvent;
            NameEvent = eventView.NameEvent;
        }
    }
}
