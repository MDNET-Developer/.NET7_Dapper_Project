using Microsoft.AspNetCore.Mvc;

namespace DapperRealEstateWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
