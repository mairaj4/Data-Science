using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Selenium_POM_JSON_Allure
{
    public static class Locators
    {
        //MakeAppointment Button
        public const string AppointButton = "btn-make-appointment";
        // Login Page Locators
        public const string UserName = "txt-username";
        public const string Password = "txt-password";
        public const string LoginButton = "btn-login";
        public const string MakeAppointText_xpath = "//h2[normalize-space()='Make Appointment']";
        

        //Appointment Locators
        public const string visitDate = "txt_visit_date";
        public const string comments = "txt_comment";
        public const string bookAppointButton = "btn-book-appointment";
        public const string AppointConfirmText_xpath = "//h2[normalize-space()='Appointment Confirmation']";

    }
}
