using Limsapp.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limsapp.Pages
{
   public class LabcorpHomePage 
    {

        [FindsBy(How = How.XPath, Using = "//div[@id='login-container']//a[text() = 'Careers']")]
        public IWebElement CareersLink { get; set; }
    }
}
