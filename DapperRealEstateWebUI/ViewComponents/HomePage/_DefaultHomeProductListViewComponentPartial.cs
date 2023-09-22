using DapperRealEstateWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DapperRealEstateWebUI.ViewComponents.HomePage
{
    public class _DefaultHomeProductListViewComponentPartial:ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultHomeProductListViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var responseMessage = await _httpClientFactory.CreateClient().GetAsync("https://localhost:7008/api/Product/GetProductWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<IEnumerable<GetProductWithCategoryModel>>(jsonData);
                return View(values);
            }

            return View();  
        }
    }
}
