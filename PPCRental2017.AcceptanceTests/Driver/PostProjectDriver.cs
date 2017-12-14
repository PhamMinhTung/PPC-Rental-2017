
using System.Web.Mvc;
using TechTalk.SpecFlow;
using PPC_Rental_2017.Controllers;
using System;

namespace PPCRental2017.AcceptanceTests.Driver
{
    public class PostProjectDriver
    {
        private ActionResult _result;
        public void Navigate(Table table)
        {
            using (var db = new UsersController())
            {
                _result = db.Login();
            }
        }

        public void NavigatePost()
        {
            using (var ps = new PostProjectController())
            {
                _result = ps.PostProject();
            }
        }

        internal void NavigateHome()
        {
            using (var ph = new HomeController())
            {
                _result = ph.Index();
            }
        }
    }
}
