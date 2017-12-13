using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPC_Rental_2017.Models;
using System.Net.Mail;

namespace PPC_Rental_2017.Controllers
{
    public class UsersController : Controller
    {
        team15Entities db = new team15Entities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Logout(int id)
        {
            var user = db.USERs.FirstOrDefault(x => x.ID == id);
            if (user != null)
            {
                Session["FullName"] = null;
                Session["UserID"] = null;

            }
            return RedirectToAction("Login", "Login");
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string fullname, string address, string password, string email, string phonenumber)
        {
            var register = new USER();
            register.FullName = fullname;
            register.Email = email;
            register.Address = address;
            register.Password = password;
            register.Phone = phonenumber;
            db.USERs.Add(register);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult ChangePass()
        {
            return View();
        }
        public ActionResult IdentiChangepass(string passOld, string passNew, string passCf)
        {
            USER var = db.USERs.Find((int)Session["UserID"]);
            if (var.Password == passOld)
            {
                if (passNew == passCf)
                {
                    var.Password = passNew;
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.error = "Password not confirm";
                    return View();
                }
            }
            else
            {
                ViewBag.error = "Password current not exactly";
                return View();
            }
        }
        public ActionResult ForgetPassword()
        {
            return View();
        }
        public async System.Threading.Tasks.Task<ActionResult> ForgetPass(string Semail, string number_phone)
        {
            if (Semail != "" && number_phone != "")
            {
                USER var = db.USERs.ToList().FirstOrDefault(s => s.Email == Semail && s.Phone == number_phone);
                if (var != null)
                {
                    string line = "qwertyuiopasdfdghjklzxcvbnm0123456789";
                    int count = line.Length - 1;

                    Random number = new Random();
                    int begin = number.Next(1, count);
                    int end = count - begin;
                    string sum = "";
                    for (int i = 0; i < 3; i++)
                    {
                        sum = sum + line.Substring(begin, end);
                    }
                    var.Password = sum;
                    db.SaveChanges();
                    ViewBag.email = Semail;
                    /////////////////////
                    var body = "<h1>Hi! " + var.FullName + " </h1";
                    body += "<p>&ensp; Email From: {0} to {1}</p><br/><p>Message:{2}</p>";
                    body += "<p>Very pleased to hear from customers<p>";
                    var message = new MailMessage();
                    message.To.Add(new MailAddress(Semail));  // replace with valid value 
                    message.From = new MailAddress("k21t1team5p1d@gmail.com");
                    message.Subject = "Your email subject";
                    message.Body = string.Format(body, "k21t1team5p1d@gmail.com", Semail, "This is your password: " + sum);
                    message.IsBodyHtml = true;

                    using (var smtp = new SmtpClient())
                    {

                        smtp.Send(message);
                        return RedirectToAction("ForgetComplete", "Agency");
                    }
                }
                else
                {
                    return View("ForgetPassword");
                }
            }
            else
            {
                ViewBag.erorr = "Password or NumberPhone not found";
                return View("ForgetPassword");
            }
        }
        public ActionResult ForgetComplete()
        {
            return View();
        }


    }
}

