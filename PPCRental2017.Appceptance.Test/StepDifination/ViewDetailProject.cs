using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental2017.Appceptance.Test;

namespace PPCRental2017.Appceptance.Test.StepDifination
{
    [Binding]
    public sealed class ViewDetailProject
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        public readonly Driver.DriverDetailProject _Driver;

        [Given(@"I have enter View list page")]
        public void GivenIHaveEnterViewListPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click One project to see information")]
        public void WhenIClickOneProjectToSeeInformation()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see information of project")]
        public void ThenISeeInformationOfProject()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
