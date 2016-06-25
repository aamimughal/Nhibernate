using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iqra.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Action1()
        {
            string datafromdatabase = "this data is coming from DB";
            int a = 16;

            ViewBag.abc = datafromdatabase;
            ViewBag.a = a;

            Session["abc"] = datafromdatabase;
            Session["a"] = a;

            return View();
        }

        public ActionResult Action2()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudent(Student S)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Action3(string abc)
        {
            Session.Remove("abc");
            //Session.RemoveAll();
            return View();
        }

        [HttpPost]
        public ActionResult Action3(string studentname, string email)
        {
            return View();
        }

    }
}