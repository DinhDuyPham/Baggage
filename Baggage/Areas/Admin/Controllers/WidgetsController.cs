using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baggage.Areas.Admin.Controllers
{
    public class WidgetsController : Controller
    {
        // GET: Admin/Widgets
        public ActionResult Index()
        {
            return View();
        }
    }
}