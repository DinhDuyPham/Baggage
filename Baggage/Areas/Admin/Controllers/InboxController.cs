using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baggage.Areas.Admin.Controllers
{
    public class InboxController : Controller
    {
        // GET: Admin/Inbox
        public ActionResult Index()
        {
            return View();
        }
    }
}