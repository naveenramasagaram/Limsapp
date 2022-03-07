using Limsapp.API;
using Limsapp.APIModels;
using Limsapp.Hooks;
using Limsapp.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Limsapp.steps
{
    [Binding]
    class LabcorpHomeStep
    {

        [Given(@"Click on CareerLink")]
        public void GivenClickOnCareerLink()
        {
            Base<LabcorpHomePage>.GetInstance<LabcorpHomePage>();

            HookInitilization.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login-container")));

            Base<LabcorpHomePage>.CurrentPage.CareersLink.Click();

            HookInitilization.driver.SwitchTo().Window(HookInitilization.driver.WindowHandles[1]);

            HookInitilization.wait.Until(ExpectedConditions.ElementIsVisible(By.Name("typehead")));
        }

        [Given(@"Get Reuest")]
        public void GivenGetReuest()
        {
           List<Users> oj = APICalls<Users>.GetList("Users");
        }

        [Given(@"Post request")]
        public void GivenPostRequest()
        {
            Users data = new Users
            {
                createdAt = 1631825833,
                employee_firstname = "TestData12345",
                employee_lastname = "TestData12345",
                employee_phonenumbe = "264-783-9453",
                ademployee_emaildress = "ademployee_emaildress 1",
                citemployee_addressy = "citemployee_addressy 1",
                stateemployee_dev_level = "stateemployee_dev_level 1",
                employee_gender = "employee_gender 1",
                employee_hire_date = Convert.ToDateTime("2025-10-31T16:35:45.426Z"),
                employee_onleave = true

            };

            APICalls<Users>.CreateAPI("Users", data);
        }


    }
}
