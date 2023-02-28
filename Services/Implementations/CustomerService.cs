using CLASSEM_MVC_PRO.Enums;
using CLASSEM_MVC_PRO.Models.DTOs.CustomerDTOs;
using CLASSEM_MVC_PRO.Models.Entities;
using CLASSEM_MVC_PRO.Repositorises.Interfaces;
using CLASSEM_MVC_PRO.Services.Interfaces;

namespace CLASSEM_MVC_PRO.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customer;
        private readonly IUserRepository _user;
        public CustomerService(ICustomerRepository customer, IUserRepository user)
        {
            _customer = customer;
            _user = user;
        }
        public UpdateCustomerBalanceRequestModel AddMoney(UpdateCustomerBalanceRequestModel customer)
        {
            var user = _customer.GetById(customer.UserId);
            if (user == null)
            {
                return null;
            }
            user.Balance += customer.Balance;
            user.Modified = DateTime.Now;
            _customer.Update(user);
            return customer;
        }
        public CreateCustomerRequestModel Create(CreateCustomerRequestModel customer)
        {
            var useId = User.GenerateId("CLM/C");
            var user = new User
            {
                UserId = useId,
                Email = customer.Email,
                Password = customer.Password,
                Role = UserRoleType.Customer,
                Created = DateTime.Now
            };
            _user.Create(user);

            var cust = new Customer
            {
                CustomerId = useId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                PhoneNumber = customer.PhoneNumber,
                Address = customer.Address,
                DateOfBirth = customer.DateOfBirth,
                Gender = customer.Gender,
                Created = DateTime.Now,
                IsActive = true,
                UserEmail = user.Email,
            };
            _customer.Create(cust);
            return customer;
        }

        public void Delete(string customerId)
        {
            var cust = _customer.GetById(customerId);
            cust.IsDeleted = true;
            _customer.Delete(cust);
        }

        public CustomerResponseModel GetByEmail(string email)
        {
            var cust = _customer.GetByEmail(email);
            if (cust == null)
            {
                return null;
            }

            var customerResponseModel = new CustomerResponseModel
            {
                Message = "Customer retrieved successfully.",
                Status = true,
                Data = new CustomerDTOs
                {
                    FirstName = cust.FirstName,
                    LastName = cust.LastName,
                    PhoneNumber = cust.PhoneNumber,
                    DateOfBirth = cust.DateOfBirth,
                    Gender = cust.Gender,
                    UserId = cust.CustomerId,
                    Address = cust.Address,
                    IsActive = cust.IsActive,
                    IsDelete = cust.IsDeleted,
                    Email = cust.UserEmail,
                    Balance = cust.Balance,
                }
            };
            return customerResponseModel;
        }

        public UpdateCustomerRequestModel GetById(string customerId)
        {
            var cust = _customer.GetById(customerId);
            var updateCustomerRequestModel = new UpdateCustomerRequestModel
            {
                UserId = cust.CustomerId,
                FirstName = cust.FirstName,
                LastName = cust.LastName,
                Address = cust.Address,
            };
            return updateCustomerRequestModel;
        }
        public IEnumerable<CustomerResponseModel> GetCustomers()
        {
            var customers = _customer.GetCustomers();

            var customerResponseModels = new List<CustomerResponseModel>();
            foreach (var customer in customers)
            {
                var customerResponseModel = new CustomerResponseModel
                {
                    Message = "Customer retrieved successfully.",
                    Status = true,
                    Data = new CustomerDTOs
                    {
                        FirstName = customer.FirstName,
                        LastName = customer.LastName,
                        PhoneNumber = customer.PhoneNumber,
                        DateOfBirth = customer.DateOfBirth,
                        Gender = customer.Gender,
                        UserId = customer.CustomerId,
                        Address = customer.Address,
                        IsActive = customer.IsActive,
                        IsDelete = customer.IsDeleted,
                        Email = customer.UserEmail,
                        Balance = customer.Balance,
                    }
                };
                customerResponseModels.Add(customerResponseModel);
            }
            return customerResponseModels;
        }

        public UpdateCustomerBalanceRequestModel RemoveMoney(UpdateCustomerBalanceRequestModel customer)
        {
            var user = _user.GetById(customer.UserId);
            if (user == null)
            {
                return null;
            }
            user.Balance -= customer.Balance;
            user.Modified = DateTime.Now;
            _user.UpdatePassword(user);
            return customer;
        }

        public UpdateCustomerRequestModel RemoveMoney(UpdateCustomerRequestModel customer)
        {
            throw new NotImplementedException();
        }

        public UpdateCustomerRequestModel Update(UpdateCustomerRequestModel customer)
        {
            var cust = _customer.GetById(customer.UserId);
            if (cust == null)
            {
                return null;
            }
            cust.FirstName = customer.FirstName ?? cust.FirstName;
            cust.LastName = customer.LastName ?? cust.LastName;
            cust.Address = customer.Address ?? cust.Address;
            cust.CustomerId = customer.UserId ?? cust.CustomerId;
            cust.Modified = DateTime.Now;
            _customer.Update(cust);
            return customer;
        }

        public UpdateCustomerPasswordRequestModel UpdatePassword(UpdateCustomerPasswordRequestModel customer)
        {
            var user = _user.GetById(customer.UserId);
            if (user == null)
            {
                return null;
            }
            user.Password = customer.Password;
            user.Modified = DateTime.Now;
            _user.UpdatePassword(user);
            return customer;
        }
    }
}