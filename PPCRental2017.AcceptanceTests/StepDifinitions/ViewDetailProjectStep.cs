using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental2017.AcceptanceTests.Driver.ViewDetails;

namespace PPCRental2017.AcceptanceTests.StepDifinitions
{
    [Binding, Scope  (Tag = "automated")]
    public sealed class ViewDetailProjectStep
    {
        private readonly ViewDetailsDriver _detailsDriver;
        public ViewDetailProjectStep ( ViewDetailsDriver driver)
        {
            _detailsDriver = driver;
        }
      

        [Given(@"the following projects")]
        public void GivenTheFollowingProjects(Table givenProjects)
        {
            _detailsDriver.InsertProjectToDB(givenProjects);
        }

        [When(@"I open the details of '(.*)'")]
        public void WhenIOpenTheDetailsOf(string givenPrjName)
        {
            _detailsDriver.OpenPropertyDetails(givenPrjName);
        }

        [Then(@"I should see the following information")]
        public void ThenIShouldSeeTheFollowingInformation(Table shownProject)
        {
            _detailsDriver.ShowDetailProject(shownProject);
        }

    }
}
