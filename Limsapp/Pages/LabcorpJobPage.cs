using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limsapp.Pages
{
    class LabcorpJobPage
    {

        [FindsBy(How = How.XPath, Using = "//button[@class='close closebutton ae-button']")]
        public IWebElement JobClosePopUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='resultfootervalue']")]
        public IWebElement JobLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class = 'jobTitle job-detail-title']")]
        public IWebElement JobTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class = 'jobnum']")]
        public IWebElement JobId { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-secondary ae-button']")]
        public IWebElement JobRetunSearch { get; set; }

        
    }
}
