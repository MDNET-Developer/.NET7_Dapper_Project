using DapperRealEstateWebApi.Dtos.CategoryDtos;
using DapperRealEstateWebApi.Dtos.ProductDtos;

namespace DapperRealEstateWebApi.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<IEnumerable<GetProductWithCategoryDto>> GetProductWithCategoriesAsync();
        Task<IEnumerable<ListProductDto>> GetAllProductsAsync();
        Task AddProductAsync(AddProductDto dto);
    }
}
