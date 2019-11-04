using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationTask.Models;
using ValidationTask.Models.DAL;

namespace ValidationTask.Controllers
{
    public class UserController : Controller
    {

        private DataContext _db = new DataContext();
        // GET: User
        public ActionResult Index()
        {
            var model = _db.UserData.ToList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserData model)
        {
            _db.UserData.Add(model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        #region retuern value


        public JsonResult CheckValue(string Email)
        {

            bool reslut = false;

            var model = _db.UserData.Where(ss => ss.Email == Email).FirstOrDefault();

            if (model !=null )
            {
                reslut = true;
            }
            

            return Json(reslut, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}