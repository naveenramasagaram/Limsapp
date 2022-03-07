using Limsapp.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Limsapp.Hooks
{
    [TestClass]
    public static class InitializeTestContext
    {
        public static TestContext Context { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Context = context;
            //Thread.Sleep(300000);
        }
    }

    [Binding]
    class HookInitilization
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;

        [BeforeScenario]
        public void ScenarioStart()
        {
        }

        [BeforeScenarioBlock("UIApp")]
        public static void DeleteEmailsInTestAccountAndGetServiceEmail()
        {
            driver = new ChromeDriver();

            //you can also use runsettings file
            string url = InitializeTestContext.Context.Properties.Contains("LabCorp") ? InitializeTestContext.Context.Properties["LabCorp"].ToString() : "https://www.labcorp.com/";
            string LongTimeout = InitializeTestContext.Context.Properties.Contains("longTimeoutSeconds") ? InitializeTestContext.Context.Properties["longTimeoutSeconds"].ToString() : "120";
            string ShortTimeout = InitializeTestContext.Context.Properties.Contains("shortTimeoutSeconds") ? InitializeTestContext.Context.Properties["shortTimeoutSeconds"].ToString() : "10";

            if (ScenarioContext.Current.CurrentScenarioBlock.ToString() == "Given")
            {
                driver.Navigate().GoToUrl(url);



                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Convert.ToInt32(ShortTimeout)));
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Convert.ToInt32(LongTimeout));
                driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(Convert.ToInt32(ShortTimeout));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Convert.ToInt32(LongTimeout));

                driver.Manage().Window.Maximize();
            }
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();


        }

    }
}
