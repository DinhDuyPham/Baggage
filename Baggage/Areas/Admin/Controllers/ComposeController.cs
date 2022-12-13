using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baggage.Areas.Admin.Controllers
{
    public class ComposeController : Controller
    {
        // GET: Admin/Compose
        public ActionResult Index()
        {
            return View();
        }
    }
}