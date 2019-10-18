using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.ViewModel
{
    public class TheatreViewModel : ITheatre
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
