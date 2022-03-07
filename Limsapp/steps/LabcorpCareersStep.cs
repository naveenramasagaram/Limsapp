using Limsapp.Hooks;
using Limsapp.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Limsapp.steps
{
    [Binding]
    class LabcorpCareersStep
    {
        [Given(@"Enter ""(.*)"" to search and Select Job from Results")]
        public void GivenEnterToSearchAndSelectJobFromResults(string JobTitle)
        {
            Base<LabcorpCareersPage>.GetInstance<LabcorpCareersPage>();
            Base<LabcorpCareersPage>.CurrentPage.SearchJob.SendKeys(JobTitle);
            Base<LabcorpCareersPage>.CurrentPage.SearchJob.SendKeys(Keys.Enter);
            Base<LabcorpCareersPage>.CurrentPage.ClickonSearchResults.Click();
        }

        [Given(@"Verify ""(.*)"" ""(.*)"" ""(.*)"" and JobDecription and tools")]
        public void GivenVerifyAndJobDecriptionAndTools(string JobId, string JobTitle, string JobLocation)
        {
            Assert.IsTrue(Base<LabcorpCareersPage>.CurrentPage.JobTitle.Text.Contains(JobTitle));
            Assert.IsTrue(Base<LabcorpCareersPage>.CurrentPage.JobLocation.Text.Contains(JobLocation));
            Assert.IsTrue(Base<LabcorpCareersPage>.CurrentPage.JobId.Text.Contains(JobId));


            Assert.IsTrue(Base<LabcorpCareersPage>.CurrentPage.ThirdParaText.Text.Contains("What you will be doing:"));
            Assert.IsTrue(Base<LabcorpCareersPage>.CurrentPage.RequirementsSecondBullet.Text.Contains("Kotlin/Java"));
            Assert.IsTrue(Base<LabcorpCareersPage>.CurrentPage.JobDescription.Text.Contains("Working with a small"));
        }


        [When(@"Click on Apply now")]
        public void WhenClickOnApplyNow()
        {
            Base<LabcorpCareersPage>.CurrentPage.JobApply.Click();
            HookInitilization.driver.SwitchTo().Window(HookInitilization.driver.WindowHandles[2]);
        }



    }
}
