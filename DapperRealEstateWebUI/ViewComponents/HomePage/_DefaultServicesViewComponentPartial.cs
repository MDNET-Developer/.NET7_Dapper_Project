using Microsoft.AspNetCore.Mvc;

namespace DapperRealEstateWebUI.ViewComponents.HomePage
{
    public class _DefaultServicesViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
