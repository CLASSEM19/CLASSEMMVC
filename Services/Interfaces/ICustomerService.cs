using CLASSEM_MVC_PRO.Models.DTOs.CustomerDTOs;

namespace CLASSEM_MVC_PRO.Services.Interfaces
{
    public interface ICustomerService
    {
        CreateCustomerRequestModel Create(CreateCustomerRequestModel customer);
        void Delete(string customerId);
        UpdateCustomerRequestModel GetById(string customerId);
        CustomerResponseModel GetByEmail(string email);
        IEnumerable<CustomerResponseModel> GetCustomers();
        UpdateCustomerRequestModel Update(UpdateCustomerRequestModel customer);
        UpdateCustomerPasswordRequestModel UpdatePassword(UpdateCustomerPasswordRequestModel customer);
        UpdateCustomerBalanceRequestModel RemoveMoney(UpdateCustomerBalanceRequestModel customer);
        UpdateCustomerBalanceRequestModel AddMoney(UpdateCustomerBalanceRequestModel customer);
    }
}