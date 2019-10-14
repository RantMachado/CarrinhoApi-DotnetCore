using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.ViewModel
{
    public class TheatreViewModel : ITheatre
    {
        public int IdTheatre { get; set; }
        public string NameTheatre { get; set; }
    }
}
