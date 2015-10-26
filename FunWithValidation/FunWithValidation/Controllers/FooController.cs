using FunWithValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunWithValidation.Controllers
{
    public class FooController : Controller
    {
        private static List<Foo> _list = new List<Foo>();

        public ActionResult Index()
        {
            ViewBag.List = _list;
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Foo model)
        {
            if (ModelState.IsValid)
            {
                _list.Add(model);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}