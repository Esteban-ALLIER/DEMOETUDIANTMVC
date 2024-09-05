using Microsoft.AspNetCore.Mvc;

namespace empty.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }

    }
}
