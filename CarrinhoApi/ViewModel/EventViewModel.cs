using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.ViewModel
{
    public class EventViewModel : IEvent
    {
        public int IdEvent { get; set; }
        public string NameEvent { get; set; }
    }
}
