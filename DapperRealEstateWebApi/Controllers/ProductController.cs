using DapperRealEstateWebApi.Dtos.ProductDtos;
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
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var data = await _productRepository.GetProductById(id);
            return Ok(data);
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> GetProductWithCategoryById(int id)
        {
            var data = await _productRepository.GetProductWithCategoryByIdAsync(id);
            return Ok(data);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProducts(int id)
        {
            await _productRepository.DeleteProductAsync(id);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> AddProducts(AddProductDto dto)
        {
            await _productRepository.AddProductAsync(dto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProducts(UpdateProductDto dto)
        {
            await _productRepository.UpdateProductAsync(dto);
            return Ok();
        }

    }
}
