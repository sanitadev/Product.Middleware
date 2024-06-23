using Product.Middleware.Data;
using Product.Middleware.Services;
using System.Collections.Generic;


namespace Product.Middleware.Data;

public class ProductRepository
{
    private List<ProductRepository> products;

    public ProductRepository()
    {
        
        products = new List<ProductRepository>();
    }

    internal static ProductService GetProductById(int id)
    {
        throw new NotImplementedException();
    }

    internal static List<ProductService> GetProductsByCategoryAndPrice(string category, decimal minPrice, decimal maxPrice)
    {
        throw new NotImplementedException();
    }

    internal static List<ProductService> SearchProductsByName(string searchText)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ProductRepository> GetAllProducts()
    {
       
        return products;
    }


}