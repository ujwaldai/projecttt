using DMS.DAL.DatabaseContext;
using DMS.DAL.Interfaces;
using DMS.DAL.StaticHelper;
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
        private MainEntities db;
        private SystemInfoForSession _ActiveSession;
        private IBranchesRepo _BranchesRepo;

        public loginController(MainEntities _db, IBranchesRepo BranchesRepo)
        {
            _ActiveSession = SessionHelper.GetSession();
            db = _db;
            _BranchesRepo = BranchesRepo;
        }
        public ActionResult Admin_Index()
        {
            return View();
        }
        public ActionResult Admin_froms()
        {
            return View();
        }
    }
}