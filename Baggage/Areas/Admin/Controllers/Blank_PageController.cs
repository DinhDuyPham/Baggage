using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baggage.Areas.Admin.Controllers
{
    public class Blank_PageController : Controller
    {
        // GET: Admin/Blank_Page
        public ActionResult Index()
        {
            return View();
        }
    }
}