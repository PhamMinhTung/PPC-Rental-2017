using PPCRental2017.AcceptanceTests.Drivers.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PPCRental2017.AcceptanceTests.StepDifinitions
{
    [Binding]
    public class LoginStep
    {
        private readonly LoginDriver _logindriver;
        public LoginStep(LoginDriver driver)
        {
            _logindriver = driver;
        }
        [Given(@"the following account")]
        public void GivenTheFollowingAccount(Table table)
        {
            _logindriver.InserttoDB(table);
        }

        [When(@"I have navigate to Login page")]
        public void WhenIHaveNavigateToLoginPage()
        {
            _logindriver.Navigate();
        }

        [When(@"I entered '(.*)' and '(.*)'")]
        public void WhenIEnteredAnd(string email, string password)
        {
            _logindriver.Login(email, password);
        }
        //[Then(@"I am at View List of Project Page")]
        //public void ThenIAmAtViewListOfProjectPage()
        //{
        //    _logindriver.NavigateViewListofProject();
        //}

    }
}
