
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPC_Rental_2017.Models;
using System.IO;

namespace PPC_Rental.Controllers
{
    public class RegisterController : Controller
    {
        team15Entities db = new team15Entities();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string Name, string Address, string Password, string mail, string Number)
        {
            var register = new USER();
            register.Email = mail;
            register.FullName = Name;
            register.Password = Password;
            //register.Phone = int.Parse(string Number);
            register.Address = Address;

            //db.U.Add(register);
            //db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}