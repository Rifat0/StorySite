using log4net;
using StorySite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorySite.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger("DebugLog");

        public ActionResult Index()
        {
            StoryContext context = new StoryContext();
            var stories = context.Stories.ToList();
            return View();
            //try
            //{
            //    int x = 10000;
            //    for (int i = 10; i>= -10; i--)
            //    {
            //        x = x / i;
            //    }


            //}catch(Exception ex)
            //{
            //    log.Debug("Error in index", ex);
            //}

        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}