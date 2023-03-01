using System.Transactions;
using CLASSEM_MVC_PRO.Context;
using CLASSEM_MVC_PRO.Repositorises.Interfaces;

namespace CLASSEM_MVC_PRO.Repositorises.Implementations
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationContext _context;
        public TransactionRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Transaction Create(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
            return transaction;
        }

        public IEnumerable<Transaction> GetAll()
        {
            var transactions = _context.Transactions.ToList();
            return transactions;
        }

        public IEnumerable<Transaction> GetByCustomerId(string customerId)
        {
            var transactions = _context.Transactions.Where(a => a.CustomerId == customerId).ToList();
            return transactions;
        }

        public Transaction GetById(string refNumber)
        {
            var transaction = _context.Transactions.SingleOrDefault(a => a.ReferenceNo == refNumber);
            return transaction;
        }

        IEnumerable<Transaction> ITransactionRepository.GetAll()
        {
            var transactions = _context.Transactions.ToList();
            return transactions;
        }

        IEnumerable<Transaction> ITransactionRepository.GetByCustomerId(string customerId)
        {
            throw new NotImplementedException();
        }

        Transaction ITransactionRepository.GetById(string refNumber)
        {
            throw new NotImplementedException();
        }
    }
}