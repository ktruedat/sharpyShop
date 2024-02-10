using Microsoft.AspNetCore.Mvc;
using sharpyShop.Repository;

namespace sharpyShop.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;
    private readonly ICateogryRepository _categoryRepository;

    public ProductController(IProductRepository productRepository, ICateogryRepository categoryRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }
}