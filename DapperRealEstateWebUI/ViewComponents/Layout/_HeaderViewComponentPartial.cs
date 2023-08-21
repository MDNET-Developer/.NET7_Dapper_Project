using Microsoft.AspNetCore.Mvc;

namespace DapperRealEstateWebUI.ViewComponents.Layout
{ 
    public class _HeaderViewComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
