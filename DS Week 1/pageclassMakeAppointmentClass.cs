using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Selenium_POM_JSON_Allure.PageClass
{
    public class MakeAppointmentClass: LoginPageClass
    {
        public void EnterAppointmentDetails()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\Administrator\\source\\repos\\BDD_Selenium_POM_JSON_Allure\\BDD_Selenium_POM_JSON_Allure\\data.json"));
            string visitDate = jsonData["visitdate"].ToString();
            string comments = jsonData["comments"].ToString();
            chromeDriver.FindElement(By.Id(Locators.visitDate)).SendKeys(visitDate);
            chromeDriver.FindElement(By.Id(Locators.comments)).SendKeys(comments);
            chromeDriver.FindElement(By.Id(Locators.bookAppointButton)).Click();

        }

        public void ValidateSuccessfullAppointmentBooked()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\Administrator\\source\\repos\\BDD_Selenium_POM_JSON_Allure\\BDD_Selenium_POM_JSON_Allure\\data.json"));
            string confirmAppointText = jsonData["appointmentconfirmationtext"].ToString();
            string text = chromeDriver.FindElement(By.XPath(Locators.AppointConfirmText_xpath)).Text;
            Assert.AreEqual(text, confirmAppointText);
        }
    }
}
