using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPCRental2017.AcceptanceTests.Drivers.Home;
using TechTalk.SpecFlow;

namespace PPCRental2017.AcceptanceTests.StepDifinitions
{
    [Binding]
    class HomeScreenStep
    {
        private readonly HomeDriver _homeDriver;
        public HomeScreenStep(HomeDriver _HomeDriver)
        {
            _homeDriver = _HomeDriver;
        }
        [When(@"I am at Home page")]
        public void WhenIAmAtHomePage()
        {
            _homeDriver.Navigate();
        }
    }
}
