using CLASSEM_MVC_PRO.Models.Entities;

namespace CLASSEM_MVC_PRO.Repositorises.Interfaces
{
    public interface IProductRepository
    {
        Product Create(Product product);
        Product Update(Product product);
        void Delete(Product product);
        Product GetById(string productId);
        IEnumerable<Product> GetAll();
    }
}