namespace ProjektMVP.Controllers
{
    using System.Web.Mvc;

    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        [Route("Index")]
        public ActionResult Index(string message = "")
        {
            @ViewBag.StatusMessage = message;
            return View();
        }

        [Route("About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        [Route("Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}