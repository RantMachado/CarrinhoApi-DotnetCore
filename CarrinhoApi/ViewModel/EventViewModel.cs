using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.ViewModel
{
    public class EventViewModel : IEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
