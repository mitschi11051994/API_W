using CRUD_API_W.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_API_W.Controllers
{
    public class tblClientController : Controller
    {
        // GET: tblClients
        public ActionResult Index()
        {
            tblClient_Client pc = new tblClient_Client();
            ViewBag.listtblClient = pc.findAll();
            return View();
        }
    }
}