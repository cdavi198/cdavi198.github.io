using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cdavi198.github.io.Controllers
{
    public class GoTController : Controller
    {
        // GET: GoT
        public ActionResult GoTHome()
        {
            return View();
        }

        public ActionResult GoTRules()
        {
            return View();
        }

        public ActionResult GoTScoring()
        {
            return View();
        }
    }

    
}