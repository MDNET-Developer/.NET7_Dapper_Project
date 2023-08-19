using DapperRealEstateWebApi.Dtos.CategoryDtos;
using DapperRealEstateWebApi.Dtos.ProductDtos;

namespace DapperRealEstateWebApi.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<IEnumerable<GetProductWithCategoryDto>> GetProductWithCategoriesAsync();
        Task<GetProductWithCategoryDto> GetProductWithCategoryByIdAsync(int id);
        Task<IEnumerable<ListProductDto>> GetAllProductsAsync();
        Task AddProductAsync(AddProductDto dto);
        Task DeleteProductAsync(int id);
        Task<GetByIdProductDto> GetProductById(int id);
        Task UpdateProductAsync(UpdateProductDto dto);    

    }
}
