using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunWithValidation.Controllers
{
    public class ValidationController : Controller
    {
        public JsonResult IsUniqueUsername(string username)
        {
            var fakeRepository = new List<string>
            {
                "username1",
                "username2",
                "username3"
            };

            return Json(!fakeRepository.Contains(username), JsonRequestBehavior.AllowGet);
        }
    }
}