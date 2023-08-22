using Microsoft.AspNetCore.Mvc;

namespace DapperRealEstateWebUI.ViewComponents.HomePage
{
    public class _DefaultLocationListViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
