using Dapper;
using DapperRealEstateWebApi.Dtos.ProductDtos;
using DapperRealEstateWebApi.Models.DapperContext;

namespace DapperRealEstateWebApi.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task AddProductAsync(AddProductDto dto)
        {
            string query = "Insert into Product(Title,Price,CoverImage,City,District,Address,Description,ProductCategory) values(@Title,@Price,@CoverImage,@City,@District,@Address,@Description,@ProductCategory)";
            var parametr = new DynamicParameters();
            parametr.Add("@Title", dto.Title);
            parametr.Add("@Price", dto.Price);
            parametr.Add("@CoverImage", dto.CoverImage);
            parametr.Add("@City", dto.City);
            parametr.Add("@District", dto.District);
            parametr.Add("@Address", dto.Address);
            parametr.Add("@Description", dto.Description);
            parametr.Add("@ProductCategory", dto.ProductCategory);

            using(var connection  = _context.CreateConnection())
            {
              await  connection.ExecuteAsync(query, parametr);
            }
        }

        public async Task<IEnumerable<ListProductDto>> GetAllProductsAsync()
        {
            string query = "Select * from Product";
            using(var connection = _context.CreateConnection())
            {
               var data = await connection.QueryAsync<ListProductDto>(query);
                return data.ToList();
            }
            
        }

        public async Task<IEnumerable<GetProductWithCategoryDto>> GetProductWithCategoriesAsync()
        {
            string query = "exec GetProductWithCategory";
            using (var connection = _context.CreateConnection())
            {
               return await connection.QueryAsync<GetProductWithCategoryDto>(query);
            }
        }
    }
}
