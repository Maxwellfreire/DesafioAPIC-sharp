using Desafio.Infra.Persistence;

namespace Desafio.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DesafioContext _context;

        public UnitOfWork(DesafioContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
