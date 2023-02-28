using CLASSEM_MVC_PRO.Context;
using CLASSEM_MVC_PRO.Models.Entities;
using CLASSEM_MVC_PRO.Repositorises.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CLASSEM_MVC_PRO.Repositorises.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationContext _context;
        public CustomerRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Customer AddMoney(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public Customer GetByEmail(string email)
        {
            var customer = _context.Customers.Include(w => w.User).FirstOrDefault(w => w.User.Email == email);
            return customer;
        }

        public Customer GetById(string customerId)
        {
            var customer = _context.Customers.SingleOrDefault(w => w.CustomerId == customerId);
            return customer;
        }
        public IEnumerable<Customer> GetCustomers()
        {
            var customers = _context.Customers.Where(w => !w.IsDeleted && w.IsActive);
            return customers;
        }

        public Customer RemoveMoney(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer UpdatePassword(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return customer;
        }
    }
}