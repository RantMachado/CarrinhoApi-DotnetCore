using CarrinhoApi.Domain.Entities.Interface;

namespace CarrinhoApi.Service.Interfaces
{
    public interface ICartService
    {
        void ValidatePromo(ICart cart);
    }
}
