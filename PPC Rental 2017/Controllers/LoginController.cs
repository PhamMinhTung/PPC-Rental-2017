using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPC_Rental_2017.Models;

namespace PPC_Rental.Controllers
{
    public class LoginController : Controller
    {
        team15Entities db = new team15Entities();
        // GET: Login
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                var userid = int.Parse(Session["UserID"].ToString());
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = db.USERs.FirstOrDefault(x => x.Email == username);
            if (user != null)
            {
                if (user.Password.Equals(password))
                {
                    Session["FullName"] = user.FullName;
                    Session["UserID"] = user.ID;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.mgs = "Tài khoản không tồn tại";
                }

            }
            return View();
        }
        public ActionResult Logout (int id)
        {
            var user = db.USERs.FirstOrDefault(x => x.ID == id);
            if (user != null) 
            {
                Session["FullName"] = null;
                Session["UserID"] = null;

            }
            return RedirectToAction("Login","Login");
        }

    }
}