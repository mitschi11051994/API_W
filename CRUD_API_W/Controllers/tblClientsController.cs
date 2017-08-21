using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_API_W.Controllers
{
    public class tblClientsController : Controller
    {
        // GET: tblClients
        public ActionResult Index()
        {
            return View();
        }
    }
}