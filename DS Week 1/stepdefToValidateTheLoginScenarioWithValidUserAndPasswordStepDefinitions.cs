using BDD_Selenium_POM_JSON_Allure.PageClass;
using System;
using TechTalk.SpecFlow;

namespace BDD_Selenium_POM_JSON_Allure.StepDefinitions
{
    [Binding]
    public class ToValidateTheLoginScenarioWithValidUserAndPasswordStepDefinitions
    {
        LoginPageClass loginPageClass = new LoginPageClass();
        [Given(@"Open Browser and goto the url")]
        public void GivenOpenBrowserAndGotoTheUrl()
        {
            loginPageClass.DriverInitiliaze();
            loginPageClass.OpenChromeWindow();
        }

        [When(@"Enter valid User and passord")]
        public void WhenEnterValidUserAndPassord()
        {
            loginPageClass.LoginMethod();
        }

        [Then(@"user should be logged in")]
        public void ThenUserShouldBeLoggedIn()
        {
            loginPageClass.ValidateSuccessfullLogin();
        }
    }
}
