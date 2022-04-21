using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    [AllowAnonymous]
    public class loginController : Controller
    {
        // GET: login
        public ActionResult Admin_Home()
        {
            return View();
        }
    }
}