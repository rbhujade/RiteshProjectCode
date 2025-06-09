using WebAPI.Model;

namespace WebAPI.Repository
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product Product);
    }
}
