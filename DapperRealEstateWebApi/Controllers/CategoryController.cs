using DapperRealEstateWebApi.Dtos.CategoryDtos;
using DapperRealEstateWebApi.Repositories.CategoryRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperRealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _category;

        public CategoryController(ICategoryRepository category)
        {
            _category = category;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryList()
        {
            var result = await _category.GetAllCategoryAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(AddCategoryDto dto)
        {
            await _category.AddCategoryAsync(dto);
            return Ok($" '{dto.CategoryName}'  uğurla əlavə olundu");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
           var data = await _category.GetCategoryByIdAsync(id);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var data = await _category.GetCategoryByIdAsync(id);
            if(data != null)
            {
                await _category.DeleteCategoryAsync(id);
                return Ok($"Uğurla silindi");
            }
            else
            {
                return BadRequest($"Id = {id} not found");
            }
         
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto dto)
        {
            await _category.UpdateCategoryAsync(dto);
            return Ok($" '{dto.CategoryID}'  uğurla yeniləndi");
        }
    }
}
