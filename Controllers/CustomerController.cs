using CLASSEM_MVC_PRO.Models.DTOs.CustomerDTOs;
using CLASSEM_MVC_PRO.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CLASSEM_MVC_PRO.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customer;
        public CustomerController(ICustomerService customer)
        {
            _customer = customer;
        }
        public IActionResult Index()
        {
            var customers = _customer.GetCustomers();
            return View(customers);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCustomerRequestModel createCustomer)
        {
            if (createCustomer != null)
            {
                var getByEmail = _customer.GetByEmail(createCustomer.Email);
                if (getByEmail == null)
                {
                    _customer.Create(createCustomer);
                    return RedirectToAction("Login", "Home");
                }
                return View();
            }
            return View();
        }

        public IActionResult Update(string customerId)
        {
            var cust = _customer.GetById(customerId);
            if (cust == null)
            {
                return View();
            }
            return View(cust);
        }
        [HttpPost]
        public IActionResult Update(UpdateCustomerRequestModel editCustomer)
        {
            _customer.Update(editCustomer);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult AddMoney(string customerId)
        {
            var cust = _customer.GetById(customerId);
            if (cust == null)
            {
                return View();
            }
            return View(cust);
        }

        [HttpPost]
        public IActionResult AddMoney(UpdateCustomerBalanceRequestModel editBalance)
        {
            _customer.AddMoney(editBalance);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeletePreview(string customerId)
        {
            if (customerId != null)
            {
                var customer = _customer.GetById(customerId);
                if (customer != null)
                {
                    return View(customer);
                }
                return NotFound();
            }
            return NotFound();
        }

        public IActionResult Delete(string customerId)
        {
            if (customerId != null)
            {
                _customer.Delete(customerId);
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }

        public IActionResult Details(string existByEmail)
        {
            if (existByEmail != null)
            {
                var customer = _customer.GetByEmail(existByEmail);
                if (customer != null)
                {
                    return View(customer);
                }
                return NotFound();
            }
            return NotFound();
        }

        public IActionResult DashBoard()
        {
            return View();
        }
    }
}