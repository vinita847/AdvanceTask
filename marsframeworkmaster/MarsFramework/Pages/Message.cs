using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using MarsFramework.Global;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace MarsFramework.Pages
{
    class Message
    {
        public Message()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        #region Web Elements

        //identify User
        [FindsBy(How = How.XPath, Using = "(//div[@class='item'])[5]")]
        private IWebElement SelectUser1 { get; set; }

        //select text box
        [FindsBy(How = How.XPath, Using = "//div[@id='input-message-container']/input")]
        private IWebElement TextBox { get; set; }

        //Identify Send tab
        [FindsBy(How = How.Id, Using = "btnSend")]
        private IWebElement SendTab { get; set; }

        //list send text
        [FindsBy(How = How.XPath, Using = "//div[@class='message - container']")]
        private IList<IWebElement> SentTexts { get; set; }
        // private IWebElement SendText { get; set; }

        //Identify send text
        [FindsBy(How = How.XPath, Using = "//div[@class='message-container']//span[contains(text(), 'Text message')]")]
        private IWebElement SentText { get; set; }


        #endregion
        public void SendingTextSteps()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Chat");
            SelectUser1.Click();

            GlobalDefinitions.wait(50);
            TextBox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "TextMessage"));
            SendTab.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[@class='message-container']//span[contains(text(), 'Text message')]"), 10);

        }

        public int LatestText()
        {
            int count = SentTexts.Count();
            Console.WriteLine(count);
            return count;
        }

        public string ExpectedMsg()
        {
            string ExpectedText = SentText.Text;
            return ExpectedText;
        }


    }
}
