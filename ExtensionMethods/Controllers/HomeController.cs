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
            string msg = String.Empty;
            switch (MyExt.SelectedOption)
            {
                case "1":
                    if (InputText.IsInteger())
                        msg = "<h1>Is Integer!</h1>";
                    else
                        msg = "<h1>Is Not Integer!<h1>";
                    break;
                case "2":
                    msg = "<h1>" + InputText + " has " + InputText.CountWords() + " words. </h1>";
                    break;
                default:
                    msg = "<h1>Selected option was not found!</h1>";
                    break;
            } // end switch

            return Content(msg);
        } // end ActionResult Index POST

    } // end public class HomeController

} // end namespace ExtensionMethods.Controllers