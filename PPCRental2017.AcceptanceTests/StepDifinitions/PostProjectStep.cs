using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using PPCRental2017.AcceptanceTests.Drivers.Login;
using PPC_Rental_2017.Models;
using PPC_Rental_2017.Controllers;
using PPCRental2017.AcceptanceTests.Support;
using PPCRental2017.AcceptanceTests.Driver;
using PPCRental2017.AcceptanceTests.Drivers.PostProject;
using PPCRental2017.AcceptanceTests.Drivers.Property;

namespace PPCRental2017.AcceptanceTests.Step
{
    [Binding]
    public class PostProjectStep
    {

        private PropertyDriver _postDriver;
        public PostProjectStep(PropertyDriver pdriver)
        {
            _postDriver = pdriver;

        }

        [Given(@"the following properties")]
        public void GivenTheFollowingProperties(Table table)
        {
            _postDriver.InsertPropertyToDB(table);
        }
       
        [When(@"I have navigate to Post Page")]
        public void WhenIHaveNavigateToPostPage()
        {
            _postDriver.NavigateToPostPage();
        }

        [When(@"I entered the following information")]
        public void WhenIEnteredTheFollowingInformation(Table table)
        {
            _postDriver.CreateProperty(table);
        }

        [When(@"I have navigate to View List of Agency Project")]
        public void WhenIHaveNavigateToViewListOfAgencyProject()
        {
            _postDriver.GetListFromViewListOfAgencyProject();
        }

        [Then(@"The list of properties shoul have my new property")]
        public void ThenTheListOfPropertiesShoulHaveMyNewProperty(Table table)
        {
            _postDriver.ShowProperty(table);
        }
    }
}

