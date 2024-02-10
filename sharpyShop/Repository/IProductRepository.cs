using sharpyShop.Models;

namespace sharpyShop.Repository;

public interface IProductRepository
{
    IEnumerable<Product> AllProducts { get; }
    Product? GetProductById(int productId);
}