using DapperRealEstateWebApi.Dtos.CategoryDtos;
using DapperRealEstateWebApi.Models.DapperContext;
using Dapper;
using DapperRealEstateWebApi.Extension;

namespace DapperRealEstateWebApi.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async Task AddCategoryAsync(AddCategoryDto addCategoryDto)
        {
            string query = "Insert into Category(CategoryName,CategoryStatus) values(@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", addCategoryDto.CategoryName);
            parameters.Add("@categoryStatus", EnumCategoryState.Aktiv);
            using (var connection = _context.CreateConnection())
            {
                 await connection.ExecuteAsync(query, parameters);
            };
        }

        public async Task DeleteCategoryAsync(int id)
        {
            string query = "Delete from Category Where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            using(var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            };
        }

        public async Task<IEnumerable<ListCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * from Category";

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<ListCategoryDto>(query);
                return result.ToList();
            };
            //var values =  await _context.CreateConnection().QueryAsync<ListCategoryDto>(query);
            //return values.ToList();
        }

        public async Task<GetByIdCategoryDto> GetCategoryByIdAsync(int id)
        {
            string query = "Select * From Category Where CategoryID=@CategoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryID", id);
            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<GetByIdCategoryDto>(query, parameters);
            }
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDto dto)
        {
            string query = "Update Category Set CategoryName = @categoryName,CategoryStatus=@categoryStatus where CategoryId = @categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", dto.CategoryName);
            parameters.Add("@categoryStatus", dto.CategoryStatus);
            parameters.Add("@categoryId", dto.CategoryID);
            using( var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query,parameters);
            };
        }
    }
}
