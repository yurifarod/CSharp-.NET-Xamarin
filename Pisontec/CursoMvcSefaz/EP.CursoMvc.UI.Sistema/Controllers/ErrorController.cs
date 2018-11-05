using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EP.CursoMvc.UI.Sistema.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index(int? code)
        {
            return View("Error");
        }

        public ActionResult AccessDanied()
        {
            return View("AccessDanied");
        }

        public ActionResult NotFound()
        {
            return View("NotFound");
        }
    }
}