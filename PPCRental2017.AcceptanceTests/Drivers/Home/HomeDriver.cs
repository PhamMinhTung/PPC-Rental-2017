using PPC_Rental_2017.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TechTalk.SpecFlow;
using PPC_Rental_2017.Models;
using PPCRental2017.AcceptanceTests.Common;
using PPCRental2017.AcceptanceTests.Support;

namespace PPCRental2017.AcceptanceTests.Drivers.Home
{
    class HomeDriver
    {
        private ActionResult _result;
        public void Navigate()
        {
            using (var controller = new HomeController())
            {
                _result = controller.Index();
            }
        }
        public void ShowProperty(Table expectedProperty)
        => ShowProperty(expectedProperty.Rows.Select(r => r["PropertyName"]));

        public void ShowProperty(IEnumerable<string> expectedTitle)
        {
            //Act
            var shownPROPERTYs = _result.Model<IEnumerable<PROPERTY>>();

            //Assert
            PropertyAssertions.HomeScreenShouldShow(shownPROPERTYs , expectedTitle);
        }
    }
}
