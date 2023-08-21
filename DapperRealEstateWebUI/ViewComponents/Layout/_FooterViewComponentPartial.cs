using Microsoft.AspNetCore.Mvc;

namespace DapperRealEstateWebUI.ViewComponents.Layout
{
    public class _FooterViewComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
