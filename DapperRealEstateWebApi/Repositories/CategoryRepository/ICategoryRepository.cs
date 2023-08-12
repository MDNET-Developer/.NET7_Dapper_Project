using DapperRealEstateWebApi.Dtos.CategoryDtos;

namespace DapperRealEstateWebApi.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<ListCategoryDto>> ListCategoryAsync();
    }
}
