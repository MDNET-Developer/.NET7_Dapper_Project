using DapperRealEstateWebApi.Repositories.ProductRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperRealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetProductWithCategory() 
        { 
            var data = await _productRepository.GetProductWithCategoriesAsync();
            return Ok(data);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var data = await _productRepository.GetAllProductsAsync();
            return Ok(data);
        }

    }
}
