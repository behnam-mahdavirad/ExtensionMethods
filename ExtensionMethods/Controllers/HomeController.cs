using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExtensionMethods.Models;

namespace ExtensionMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        } // end ActionResult Index GET

        [HttpPost]
        public ActionResult Index(ExtensionMethodModel MyExt)
        {
            string InputText = MyExt.MyText;
            if (InputText.IsInteger())
                return Content("<h1>Is Integer!</h1>");
            else
                return Content("<h1>Is Not Integer!<h1>");

        } // end ActionResult Index POST

    } // end public class HomeController

} // end namespace ExtensionMethods.Controllers