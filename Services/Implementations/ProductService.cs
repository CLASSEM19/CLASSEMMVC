using CLASSEM_MVC_PRO.Models.DTOs.AdminDTOs;
using CLASSEM_MVC_PRO.Models.DTOs.ProductDTOs;
using CLASSEM_MVC_PRO.Models.Entities;
using CLASSEM_MVC_PRO.Repositorises.Interfaces;
using CLASSEM_MVC_PRO.Services.Interfaces;

namespace CLASSEM_MVC_PRO.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _product;
        public ProductService(IProductRepository product)
        {
            _product = product;
        }

        public CreateProductRequestModel Create(CreateProductRequestModel product)
        {
            Random rand = new Random();
            var ProductIds = "CLM/" + rand.Next(0001, 1000) + "/PRD";
            var proud = new Product
            {
                ProductId = ProductIds,
                Name = product.Name,
                Color = product.Color,
                Description = product.Description,
                Engine = product.Engine,
                SellingPrice = product.SellingPrice,
                IsAvailable = true,
                Created = DateTime.Now,
            };
            _product.Create(proud);
            return product;
        }

        public void Delete(string productId)
        {
            var proud = _product.GetById(productId);
            if (proud == null)
            {
                return;
            }
            proud.IsDeleted = true;
            _product.Delete(proud);
        }

        public IEnumerable<ProductResponseModel> GetAll()
        {
            var proud = _product.GetAll();
            var products = new List<ProductResponseModel>();
            foreach (var product in proud)
            {
                var productResponseModel = new ProductResponseModel
                {
                    Message = "Product Retrieved Successfully.",
                    Status = true,
                    Data = new ProductDTOs
                    {
                        ProductId = product.ProductId,
                        Name = product.Name,
                        Description = product.Description,
                        SellingPrice = product.SellingPrice,
                        Color = product.Color,
                        Engine = product.Engine,
                    }
                };
                products.Add(productResponseModel);
            }
            return products;
        }

        public ProductResponseModel GetById(string productId)
        {
           var proud = _product.GetById(productId);
            if (proud == null)
            {
                return null;
            }
            var produc = new ProductResponseModel
            {
                Message = "Product Retrieved Successfully.",
                Status = true,
                Data = new ProductDTOs
                {
                    ProductId = proud.ProductId,
                    Name = proud.Name,
                    Description = proud.Description,
                    SellingPrice = proud.SellingPrice,
                    Color = proud.Color,
                    Engine = proud.Engine,
                }
            };
            return produc;
        }

        public UpdateProductRequestModel Update(UpdateProductRequestModel product)
        {
            var proud = _product.GetById(product.ProductId);
            proud.SellingPrice = product.SellingPrice;
            proud.Color = product.Color;
            proud.Engine = product.Engine;
            proud.Name = product.Name ?? proud.Name;
            proud.Description = product.Description ?? proud.Description;
            _product.Update(proud);
            return product;
        }
    }
}