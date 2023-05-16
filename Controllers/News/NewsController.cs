using System.Web.Mvc;

namespace webbanmeo.Controllers.News
{
    public class NewsController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}