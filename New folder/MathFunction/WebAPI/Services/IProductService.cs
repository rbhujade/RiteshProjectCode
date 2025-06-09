using WebAPI.Model;

namespace WebAPI.Services
{
    public interface IProductService
    {
        Product GetProductById(int id);
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product Product);
    }
}
