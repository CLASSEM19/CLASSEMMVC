using CLASSEM_MVC_PRO.Context;
using CLASSEM_MVC_PRO.Models.Entities;
using CLASSEM_MVC_PRO.Repositorises.Interfaces;

namespace CLASSEM_MVC_PRO.Repositorises.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _context;
        public ProductRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void Delete(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            var proud = _context.Products.Where(w => w.IsAvailable && !w.IsDeleted);
            return proud;
        }

        public Product GetById(string productId)
        {
            var proud = _context.Products.SingleOrDefault(a => !a.IsDeleted && a.IsAvailable && a.ProductId == productId);
            return proud;
        }

        public Product Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return product;
        }
    }
}