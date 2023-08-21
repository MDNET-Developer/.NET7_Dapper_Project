using Microsoft.AspNetCore.Mvc;

namespace DapperRealEstateWebUI.ViewComponents.HomePage
{
    public class _DefaultFeatureViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
