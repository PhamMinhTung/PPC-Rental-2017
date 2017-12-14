using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;

namespace PPC_Rental_2017.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string Name, string Email, string Address, string Message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderemail = new MailAddress("k21t1team5p1d@gmail.com", "Hỗ trợ");//mail agency
                    var receiveremail = new MailAddress("phamminhtung111097@gmail.com", "Công ty PPC Rental"); //mail công ty

                    var password = "skyblue1110";// mật khẩu địa chỉ mail   
                    
                    var body = "Tên: " + Name + " Email: " + Email + " Tiêu đề: " + Address + " Nội dung: " + Message;
                    // nội dung tin nhắn


                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderemail.Address, password)

                    };

                    using (var mess = new MailMessage(senderemail, receiveremail)
                    {
                        
                        Body = body
                    }
                    )
                    {
                        smtp.Send(mess);
                    }
                    return RedirectToAction("Index", "home");
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "There are some problem in sending email";
            }
            return View();
        }
    }
}