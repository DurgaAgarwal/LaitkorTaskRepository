using Laitkor_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laitkor_Task.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Login(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    User IsUserExist = DummyDb.getUsers().Find(x => x.UserName == user.UserName && x.Password == user.Password);
                    if (IsUserExist != null)
                    {
                        TempData["UserId"] = IsUserExist.UserId;
                        TempData.Keep("UserId");
                        return RedirectToAction("Dashboard");
                    }
                    else
                    {
                        TempData["Message"] = "User Not Found!";
                    }

                }
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return View();
            }
        }

        public ActionResult Dashboard()
        {

            if (TempData["UserId"] != null)
            {
                var UserId = TempData["UserId"];
                Session["UserId"] = UserId;
                User IsUserExist = DummyDb.getUsers().Find(x => x.UserId == UserId.ToString());
                return View(IsUserExist);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}
