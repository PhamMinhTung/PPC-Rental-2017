using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using PPCRental2017.AcceptanceTests.Driver;
using PPC_Rental_2017.Models;

namespace PPCRental2017.AcceptanceTests.Step
{
    [Binding]
    public class PostProjectStep
    {
        private readonly PostProjectDriver _postDriver;

        public PostProjectStep(PostProjectDriver driver)
        {
            _postDriver = driver;
        }
        [Given(@"I am login")]
        public void GivenIAmLogin(Table table)
        {
            _postDriver.Navigate(table);
        }

        [When(@"I click button post")]
        public void WhenIClickButtonPost()
        {
            _postDriver.NavigatePost();
        }


        [When(@"I input value into form")]
        public void WhenIInputValueIntoForm(Table project)
        {
            var db = new team15Entities();
            foreach (var row in project.Rows)
            {
                var Postpr = new PROPERTY
                {
                    PropertyName = row["Property Name"],
                    PropertyType_ID = int.Parse(row["Property Name"]),
                    Content = row["Content"],
                    Street_ID = int.Parse(row["Street"]),
                    Ward_ID = int.Parse(row["Ward"]),
                    District_ID = int.Parse(row["District"]),
                    Price = int.Parse(row["Price"]),
                    Area = row["Area"],
                    BathRoom = int.Parse(row["BathRoom"]),
                    BedRoom = int.Parse(row["Bedroom"]),
                    PackingPlace = int.Parse(row["Packing Place"])
                };
                db.PROPERTies.Add(Postpr);
            }
        }

        [When(@"I press create")]
        public void WhenIPressCreate()
        {
            WhenIClickButtonPost();
        }

        [Then(@"System show Home page")]
        public void ThenSystemShowHomePage()
        {
            _postDriver.NavigateHome();
        }
    }
}
