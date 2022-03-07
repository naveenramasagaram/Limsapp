using Limsapp.Hooks;
using Limsapp.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Limsapp.steps
{
    [Binding]
    class LabcorpJobStep
    {

        [Then(@"Verify ""(.*)"" ""(.*)"" ""(.*)"" and Click Return job Search")]
        public void ThenVerifyAndClickReturnJobSearch(string JobId, string JobTitle, string JobLocation)
        {
            
            Base<LabcorpJobPage>.GetInstance<LabcorpJobPage>();
            Base<LabcorpJobPage>.CurrentPage.JobClosePopUp.Click();
            Assert.IsTrue(Base<LabcorpJobPage>.CurrentPage.JobTitle.Text.Contains(JobTitle));

            string jack = Base<LabcorpJobPage>.CurrentPage.JobLocation.Text;
            Assert.IsTrue(JobLocation.Contains(Base<LabcorpJobPage>.CurrentPage.JobLocation.Text.ToString().Split(',')[0]));


            Assert.IsTrue(Base<LabcorpJobPage>.CurrentPage.JobId.Text.Contains(JobId));
            Base<LabcorpJobPage>.CurrentPage.JobRetunSearch.Click();
        }


    }
}
