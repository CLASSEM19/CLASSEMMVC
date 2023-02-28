using CLASSEM_MVC_PRO.Models.DTOs.AdminDTOs;
using CLASSEM_MVC_PRO.Models.DTOs.ProductDTOs;

namespace CLASSEM_MVC_PRO.Services.Interfaces
{
    public interface IProductService
    {
        CreateProductRequestModel Create(CreateProductRequestModel product);
        UpdateProductRequestModel Update(UpdateProductRequestModel product);
        void Delete(string productId);
        ProductResponseModel GetById(string productId);
        IEnumerable<ProductResponseModel> GetAll();
    }
}