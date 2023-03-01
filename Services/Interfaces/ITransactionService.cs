using CLASSEM_MVC_PRO.Models.DTOs.TransactionDTOs;

namespace CLASSEM_MVC_PRO.Services.Interfaces
{
    public interface ITransactionService
    {
        CreateTransactionRequestModel Create(CreateTransactionRequestModel transaction);
        IEnumerable<TransactionResponseModel> GetAll();
        IEnumerable<TransactionResponseModel> GetByDate(DateTime dateTime);
        IEnumerable<TransactionResponseModel> GetByCustomerId(string customerId);
        TransactionResponseModel GetById(string productId);
    }
}