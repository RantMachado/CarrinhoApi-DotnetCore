using System.Threading.Tasks;
using CarrinhoApi.UoW.Interfaces;
using CarrinhoApi.Data.Interfaces;

namespace CarrinhoApi.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IMongoContext _context;

        //Really?
        public UnitOfWork(IMongoContext context)
        {
            _context = context;
        }

        public async Task<bool> Commit()
        {
            var changeAmount = await _context.SaveChanges();
            return changeAmount > 0;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
