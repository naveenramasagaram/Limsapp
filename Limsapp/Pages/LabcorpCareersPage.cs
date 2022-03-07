using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limsapp.Pages
{
    class LabcorpCareersPage
    {

        [FindsBy(How = How.XPath, Using = "//input[@name = 'typehead']")]
        public IWebElement SearchJob { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='job-title']//span[contains(text(),'QA Automation Engineer')]")]
        public IWebElement ClickonSearchResults { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-ph-at-id ='job-info']//*[@class='job-title']")]
        public IWebElement JobTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-ph-at-id ='job-info']//span[contains(@class,'job-location')]")]
        public IWebElement JobLocation { get; set; }



        [FindsBy(How = How.XPath, Using = "//div[@data-ph-at-id ='job-info']//span[contains(@class,'jobId')]")]
        public IWebElement JobId { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='job-description']//p[3]")]
        public IWebElement ThirdParaText { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[text()='Requirements']/parent::div//li[2]")]
        public IWebElement RequirementsSecondBullet { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='job-description']//p[3]/following-sibling::ul//li[1]")]
        public IWebElement JobDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='job-header-actions']//a[@data-ph-at-id = 'apply-link']")]
        public IWebElement JobApply { get; set; }

    }
}
