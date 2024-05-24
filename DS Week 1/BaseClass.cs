using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Selenium_POM_JSON_Allure
{
    public class BaseClass
    {
        /// <summary>
        /// Chrome Driver initialization
        /// </summary>
        public static ChromeDriver chromeDriver;
        

        /// <summary>
        /// Chrome Driver function
        /// </summary>
        public void DriverInitiliaze()
        {
            chromeDriver = new ChromeDriver();
        }

        public void CloseDriver()
        {
            chromeDriver.Close();
        }

        public void OpenChromeWindow()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\Administrator\\source\\repos\\BDD_Selenium_POM_JSON_Allure\\BDD_Selenium_POM_JSON_Allure\\data.json"));
            string url = jsonData["url"].ToString();
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl(url);

        }
    }
}
