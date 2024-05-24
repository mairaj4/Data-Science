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
    public class LoginPageClass : BaseClass
    {

        public void LoginMethod()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\Administrator\\source\\repos\\BDD_Selenium_POM_JSON_Allure\\BDD_Selenium_POM_JSON_Allure\\data.json"));
            string url = jsonData["url"].ToString();
            string userName = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            chromeDriver.FindElement(By.Id(Locators.AppointButton)).Click();
            chromeDriver.FindElement(By.Id(Locators.UserName)).SendKeys(userName);
            chromeDriver.FindElement(By.Id(Locators.Password)).SendKeys(password);
            chromeDriver.FindElement(By.Id(Locators.LoginButton)).Click();

        }

        public void ValidateSuccessfullLogin()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\Administrator\\source\\repos\\BDD_Selenium_POM_JSON_Allure\\BDD_Selenium_POM_JSON_Allure\\data.json"));
            string url = jsonData["url"].ToString();
            string makeAppointText = jsonData["makeappointtext"].ToString();
            string text = chromeDriver.FindElement(By.XPath(Locators.MakeAppointText_xpath)).Text;
            Assert.AreEqual(text, makeAppointText);
        }

        
    }
}
