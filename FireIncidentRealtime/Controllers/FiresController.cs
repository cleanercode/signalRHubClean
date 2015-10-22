using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace davidhartmanninfo.FireIncidentRealtime.Controllers
{
    public class FiresController : Controller
    {
        // GET: Fires
        public ActionResult Index()
        {
            return View();
        }
    }
}