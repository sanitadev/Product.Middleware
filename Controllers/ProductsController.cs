using Microsoft.AspNetCore.Mvc;
using Product.Middleware.Services;

namespace Product.Middleware.Controllers;

public class ProductsController : Controller
{

    [HttpGet]
    public IActionResult GetProducts(ProductService productService)
    {
        var products = productService.GetProducts();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult GetProductById(int id, ProductService productService)
    {
        var product = productService.GetProductById(id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [HttpGet]
    public IActionResult GetProductsByCategoryAndPrice(string category, decimal minPrice, decimal maxPrice, ProductService productService)
    {
        var products = productService.GetProductsByCategoryAndPrice(category, minPrice, maxPrice);
        return Ok(products);
    }

    [HttpGet]
    public IActionResult SearchProductsByName(string searchText, ProductService productService)
    {
        var products = productService.SearchProductsByName(searchText);
        return Ok(products);
    }
}
