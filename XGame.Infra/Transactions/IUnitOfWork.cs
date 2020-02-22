namespace Desafio.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
