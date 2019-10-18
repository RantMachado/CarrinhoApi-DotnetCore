using CarrinhoApi.ViewModel;

namespace CarrinhoApi.Service.Interfaces
{
    public interface ICartService
    {
        void ValidatePromo(CartViewModel cart);
    }
}
