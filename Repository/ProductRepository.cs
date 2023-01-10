using ModelBinder.Models;
using System.Collections.Generic;

namespace ModelBinder.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<ProductModel> products = new List<ProductModel>();
        public int AddProduct(ProductModel product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return product.Id;
        }
        public List<ProductModel> GetAllProducts() => products;
    }
}
