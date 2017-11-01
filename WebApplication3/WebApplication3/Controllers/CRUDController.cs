using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class CRUDController : Controller
    {
        DFContext db = new DFContext();
        public ActionResult Index()
        {

            return View(db.EmpUsers.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmpUser empUser)
        {
            if (ModelState.IsValid)
                {
                db.EmpUsers.Add(empUser);
                db.SaveChanges();
                return RedirectToAction("Index");
                }
            return View();
        }
    }
}