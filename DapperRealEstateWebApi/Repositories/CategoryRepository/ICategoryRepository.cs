using DapperRealEstateWebApi.Dtos.CategoryDtos;

namespace DapperRealEstateWebApi.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<ListCategoryDto>> GetAllCategoryAsync();
        Task AddCategoryAsync(AddCategoryDto addCategoryDto);
        Task DeleteCategoryAsync(int id);
        Task UpdateCategoryAsync(UpdateCategoryDto dto);
        Task<GetByIdCategoryDto> GetCategoryByIdAsync(int id);
    }
}
