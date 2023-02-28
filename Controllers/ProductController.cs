using CLASSEM_MVC_PRO.Models.DTOs.AdminDTOs;
using CLASSEM_MVC_PRO.Models.DTOs.ProductDTOs;
using CLASSEM_MVC_PRO.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CLASSEM_MVC_PRO.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _product;
        public ProductController(IProductService product)
        {
            _product = product;
        }
        public IActionResult Index()
        {
            var products = _product.GetAll();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateProductRequestModel product)
        {

            if (product != null)
            {
                var existByName = _product.GetById(product.ProductId);
                if (existByName == null)
                {
                    _product.Create(product);
                    return RedirectToAction("Index", "Product");
                }
                return View();
            }
            return View(product);
        }

        public IActionResult Update(string productId)
        {
            var produc = _product.GetById(productId);
            if (productId == null)
            {
                return NotFound();
            }
            var proud = new UpdateProductRequestModel
            {
                ProductId = produc.Data.ProductId,
                Color = produc.Data.Color,
                Name = produc.Data.Name,
                Description = produc.Data.Description,
                Engine = produc.Data.Engine,
                SellingPrice = produc.Data.SellingPrice,
            };
            return View(proud);
        }

        [HttpPost]
        public IActionResult Update(UpdateProductRequestModel product)
        {
            if (product != null)
            {
                _product.Update(product);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(product);
            }
        }

        public IActionResult DeletePreview(string productId)
        {
            if (productId != null)
            {
                var product = _product.GetById(productId);
                if (product != null)
                {
                    return View(product);
                }
                return NotFound();
            }

            return NotFound();
        }
        public IActionResult Delete(string productId)
        {
            if (productId != null)
            {
                _product.Delete(productId);
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }

        public IActionResult Details(string productId)
        {
            if (productId != null)
            {
                var product = _product.GetById(productId);
                if (product != null)
                {
                    return View(product);
                }
                return NotFound();
            }
            return NotFound();
        }
    }
}