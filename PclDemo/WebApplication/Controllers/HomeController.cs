using System.Web.Mvc;
using Library;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var greeter = new Greeter();
            return View((object)greeter.Greet());
        }
    }
}