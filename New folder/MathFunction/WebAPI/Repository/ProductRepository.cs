using System.Collections.Generic;
using WebAPI.Model;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductRepository(ProductDbContext context) 
        { 
            _context = context;
        }

        public Product GetProductById(int id)
        {
            Product result = _context.Products.FirstOrDefault(w => w.Id == id);
            return result;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            List<Product> products = _context.Products.ToList();
            return products;
        }
        public void AddProduct(Product Product)
        {
            _context.Add(Product);
            _context.SaveChanges();
        }
    }
}
