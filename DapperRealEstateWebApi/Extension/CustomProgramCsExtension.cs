using DapperRealEstateWebApi.Models.DapperContext;
using DapperRealEstateWebApi.Repositories.CategoryRepository;
using DapperRealEstateWebApi.Repositories.ProductRepository;

namespace DapperRealEstateWebApi.Extension
{
    public static class CustomProgramCsExtension
    {
        public static void CustomProgramCs(this IServiceCollection services)
        {
           services.AddTransient<Context>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
