using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Apocalypsey_s_Blog.ViewModels;

namespace Apocalypsey_s_Blog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            if (Session["userName"] == "")
            {
                model.IsLogIn = false;
            }
            else
            {
                model.IsLogIn = true;
            }
            return View("~/Views/Home/Index.cshtml", model);
        }

        public ActionResult About() 
        {
            return View("~/Views/Home/About.cshtml");
        }
    }
}
