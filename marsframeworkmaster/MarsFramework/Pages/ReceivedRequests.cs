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
    class ReceivedRequests
    {
        public ReceivedRequests()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);

        }

        //Accept
        [FindsBy(How = How.XPath, Using = "(//button[contains(.,'Accept')])[1]")]
        private IWebElement AcceptReq { get; set; }

        //Decline
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Selling computers')]//parent::td//following-sibling::td[6]//button[contains(text(), 'Decline')]")]
        private IWebElement DeclineReq { get; set; }

        //Success Msg
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]")]
        public IWebElement ReqSuccessMsg { get; set; }

        //Completed
        [FindsBy(How = How.XPath, Using = "//button[@class='ui positive basic button']")]
        private IWebElement ReqCompleted { get; set; }



        public void RequestAccept()
        {
            AcceptReq.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]"), 10);
        }
        public void RequestDecline()
        {
            DeclineReq.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]"), 10);
        }

        public void RequestCompleted()
        {
            bool isPresent = ReqCompleted.Displayed;
           //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]"), 10);
        }
    }
}
