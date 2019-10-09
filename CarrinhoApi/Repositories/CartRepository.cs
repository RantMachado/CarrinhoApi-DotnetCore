using CarrinhoApi.Domain.Entities;
using CarrinhoApi.Data.Interfaces;
using CarrinhoApi.Repositories.Interfaces;

namespace CarrinhoApi.Repositories
{
    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        public CartRepository(IMongoContext context) : base(context)
        {
        }
    }
}