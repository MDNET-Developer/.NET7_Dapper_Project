using Microsoft.AspNetCore.Mvc;

namespace DapperRealEstateWebUI.ViewComponents.Layout
{
    public class _NavbarViewComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
