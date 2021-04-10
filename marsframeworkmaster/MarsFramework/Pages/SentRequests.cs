using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class SentRequests
    {
        //constructor to initialize the web elements
        public SentRequests()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        //withdraw
        [FindsBy(How = How.XPath, Using = "(//button[contains(.,'Withdraw')])[1]")]
        private IWebElement ReqWithdraw { get; set; }

        //status: Withdraw
        [FindsBy(How = How.XPath, Using = "(//td[@class='one wide'][contains(.,'Withdrawn')])[1]")]
        private IWebElement WithdrawStatus { get; set; }

        //(//td[@class='one wide'][contains(.,'Pending')])[1]

        //Status Pending
        [FindsBy(How = How.XPath, Using = "(//td[@class='one wide'][contains(.,'Pending')])[1]")]
        private IWebElement PendingStatus { get; set; }

        

        public void WithdrawSentRequest()
        {
            ReqWithdraw.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]"), 10);
        }

       
    }
}
