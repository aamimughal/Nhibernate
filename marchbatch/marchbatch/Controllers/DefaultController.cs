using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace marchbatch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
            
        {
            return View();
        }
        public string Index3()

        {
            string data = "<h1>this is h1 tag</h1>";
            return data;
        }
    }
}
