using System.Collections.Generic;
using WebAPI.Model;
using WebAPI.Repository;

namespace WebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository) 
        { 
            _productRepository = productRepository;
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
        public void AddProduct(Product Product)
        {
            _productRepository.AddProduct(Product);
        }
    }
}
