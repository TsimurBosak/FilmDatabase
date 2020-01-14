using Timur.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Timur.Controllers
{
    public class AccountController : Controller
    {
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = null;
                using (TimurContext db = new TimurContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Login == model.Name && u.Password == model.Password);
                }
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Name, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с такими данными не существует");
                }
            }
            return View(model);
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = null;
                using (TimurContext db = new TimurContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Login == model.Name);
                }
                if (user == null)
                {
                    using (TimurContext db = new TimurContext())
                    {
                        db.Users.Add(new User { Login = model.Name, Password = model.Password, RoleId = 2 });

                        db.SaveChanges();

                        user = db.Users.Where(u => u.Login == model.Name && u.Password == model.Password).FirstOrDefault();
                    }
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Name, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Данный логин не доступен");
                }
            }
            return View(model);
        }
        public ActionResult Exit()
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
            return RedirectToAction("Index", "Home");
        }
    }
}