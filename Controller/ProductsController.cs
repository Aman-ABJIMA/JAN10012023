using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBinder.Models;
using ModelBinder.Repository;

namespace ModelBinder.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
           _productRepository= productRepository;
        }
        [HttpPost("")]
        public IActionResult AddProduct([FromBody]ProductModel product)
        { 
            _productRepository.AddProduct(product);
            var products = _productRepository.GetAllProducts();  
            return Ok(products);
        }
    }
}
