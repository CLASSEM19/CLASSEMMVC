using System.Transactions;

namespace CLASSEM_MVC_PRO.Repositorises.Interfaces
{
    public interface ITransactionRepository
    {
        Transaction Create(Transaction transaction);
        IEnumerable<Transaction> GetAll();
        IEnumerable<Transaction> GetByCustomerId(string customerId);
        Transaction GetById(string refNumber);
    }
}