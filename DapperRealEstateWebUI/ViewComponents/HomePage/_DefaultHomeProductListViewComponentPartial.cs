using Microsoft.AspNetCore.Mvc;

namespace DapperRealEstateWebUI.ViewComponents.HomePage
{
    public class _DefaultHomeProductListViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
