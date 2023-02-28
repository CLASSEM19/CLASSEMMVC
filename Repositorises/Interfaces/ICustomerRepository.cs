using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLASSEM_MVC_PRO.Models.Entities;

namespace CLASSEM_MVC_PRO.Repositorises.Interfaces
{
    public interface ICustomerRepository
    {
        Customer Create(Customer customer);
        void Delete(Customer customer);
        Customer GetById(string customerId);
        Customer GetByEmail(string email);
        IEnumerable<Customer> GetCustomers();
        Customer Update(Customer customer);
        Customer UpdatePassword(Customer customer);
        Customer RemoveMoney(Customer customer);
        Customer AddMoney(Customer customer);
    }
}