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

        public async Task DeleteProductAsync(int id)
        {
            string query = "Delete from Product where ProductId = @productId";
            var parametr = new DynamicParameters();
            parametr.Add("productId", id);
           using(var connections = _context.CreateConnection())
            {
              await connections.ExecuteAsync(query, parametr);
            };
            
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

        public async Task<GetByIdProductDto> GetProductById(int id)
        {
            string query = "Select * from Product where ProductId = @productId";
            var parametr = new DynamicParameters();
            parametr.Add("productId", id);
            using( var connections = _context.CreateConnection())
            {
               return await connections.QueryFirstOrDefaultAsync<GetByIdProductDto>(query, parametr);
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

        public async Task<GetProductWithCategoryDto> GetProductWithCategoryByIdAsync(int id)
        {
            string query = "exec GetProductWithCategoryByID @product_id=@productid";
            var parametr = new DynamicParameters();
            parametr.Add("productid", id);
            using(var  connections = _context.CreateConnection())
            {
               return await connections.QueryFirstOrDefaultAsync<GetProductWithCategoryDto>(query, parametr);
            }
        }

        public async Task UpdateProductAsync(UpdateProductDto dto)
        {
            string query = "Update Product Set Title = @title,Price=@price,CoverImage=@coverImage,City=@city,District=@district,Address=@address,Description=@description,ProductCategory=@productCategory where CategoryId = @categoryId";
            var parametr = new DynamicParameters();
            parametr.Add("title",dto.Title);
            parametr.Add("price",dto.Price);
            parametr.Add("coverImage",dto.CoverImage);
            parametr.Add("city",dto.City);
            parametr.Add("district", dto.District);
            parametr.Add("address", dto.Address);
            parametr.Add("description", dto.Description);
            parametr.Add("productCategory", dto.ProductCategory);

            using(var connection = _context.CreateConnection()) 
            {
                await connection.ExecuteAsync(query, parametr);
            }
            throw new NotImplementedException();
        }
    }
}
