using ModelBinder.Models;
using System.Collections.Generic;

namespace ModelBinder.Repository
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();
    }
}