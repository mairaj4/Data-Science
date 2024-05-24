using BDD_Selenium_POM_JSON_Allure.PageClass;
using System;
using TechTalk.SpecFlow;

namespace BDD_Selenium_POM_JSON_Allure.StepDefinitions
{
    [Binding]
    public class ToSuccessfullyMakeAppointmentStepDefinitions
    {
        LoginPageClass loginPageClass = new LoginPageClass();
        MakeAppointmentClass makeAppointmentClass = new MakeAppointmentClass();
        [Given(@"Browser should be open and user should be logged in")]
        public void GivenBrowserShouldBeOpenAndUserShouldBeLoggedIn()
        {
            loginPageClass.DriverInitiliaze();
            loginPageClass.OpenChromeWindow();
            loginPageClass.LoginMethod();
        }

        [When(@"user will enter Appointment details and book appointment")]
        public void WhenUserWillEnterAppointmentDetailsAndBookAppointment()
        {
            makeAppointmentClass.EnterAppointmentDetails();
        }

        [Then(@"user will validate appointment confirmation")]
        public void ThenUserWillValidateAppointmentConfirmation()
        {
            makeAppointmentClass.ValidateSuccessfullAppointmentBooked();
        }
    }
}
