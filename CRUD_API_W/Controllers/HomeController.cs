using System.Web.Mvc;
using System.Web.Security;
using CRUD_API_W.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult IndexUser()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Home");
        }
    }
}