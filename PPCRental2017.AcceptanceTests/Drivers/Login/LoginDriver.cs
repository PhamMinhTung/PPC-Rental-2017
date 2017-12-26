using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPC_Rental_2017.Models;
using PPCRental2017.AcceptanceTests.Support;
using PPC_Rental_2017.Controllers;
using System.Web.Mvc;
using TechTalk.SpecFlow;
using System.Web;

namespace PPCRental2017.AcceptanceTests.Drivers.Login
{
    public class LoginDriver
    {
        team15Entities db = new team15Entities();
        private readonly CatalogContentU _content;
        private ActionResult _result;
        private UsersController agency;
        public USER us;
        public LoginDriver(CatalogContentU context)
        {
            _content = context;
        }
        public void InserttoDB(Table us)
        {
            using (db)
            {
                foreach (var row in us.Rows)
                {
                    var user = new USER
                    {
                        Email = row["Email"],
                        Password = row["Password"],
                        FullName = row["FullName"],
                        Phone = row["Phone"],
                        Address = row["Address"],
                        Role = row["Role"],
                        Status = true,


                    };
                    _content.ReferenceUsers.Add(us.Header.Contains("ID") ? row["ID"] : user.Email, user);
                    db.USERs.Add(user);
                }
                db.SaveChanges();
            }
        }

       

        public void Navigate()
        {
            using (var controller = new UsersController())
            {
                
                _result = controller.Login();
            }
        }
       
        public void Login(string email, string password)
        {
            agency = new UsersController();
            db = new team15Entities();
            us = db.USERs.FirstOrDefault(d => d.Email == email);

            var moqContext = new Moq.Mock<ControllerContext>();
            var moqSession = new Moq.Mock<HttpSessionStateBase>();
            moqContext.Setup(c => c.HttpContext.Session).Returns(moqSession.Object);
            agency.ControllerContext = moqContext.Object;
            moqSession.Setup(s => s["UserRole"]).Returns("1");

            us.Email = email;
            us.Password = password;

            agency.Login(email, password);
        }
        //  public void NavigateViewListofProject()
        //{
        //    using (var controller = new ViewListofProjectController())
        //    {
                
        //        _result = controller.Unapproved();
        //    }
        //}
    }
}
