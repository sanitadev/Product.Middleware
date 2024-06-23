namespace Product.Middleware.Services;

using Product.Middleware.Data;


    public class ProductService
    {
            private readonly ProductRepository _productRepository;

            public ProductService(ProductRepository productRepository)
            {
                productRepository = productRepository;
            }

    public List<ProductService> GetProducts()
            {
                return ProductRepository.GetAllProducts();
            }

            public ProductService GetProductById(int id)
            {
                return ProductRepository.GetProductById(id);
            }

            public List<ProductService> GetProductsByCategoryAndPrice(string category, decimal minPrice, decimal maxPrice)
            {
                return ProductRepository.GetProductsByCategoryAndPrice(category, minPrice, maxPrice);
            }

            public List<ProductService> SearchProductsByName(string searchText)
            {
                return ProductRepository.SearchProductsByName(searchText);
            }
        }
   