using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using MarsFramework.Global;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

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
        [FindsBy(How = How.XPath, Using = "//div[@id='chatList']/div[1]")]
        private IWebElement SelectUser1 { get; set; }

        //select text box
        [FindsBy(How = How.XPath, Using = "//div[@id='input-message-container']/input")]
        private IWebElement TextBox { get; set; }

        //Identify Send tab
        [FindsBy(How = How.Id, Using = "btnSend")]
        private IWebElement SendTab { get; set; }

        //Identify send text
        [FindsBy(How = How.XPath, Using = "//div[@id='right']/div/span[contains(text(), 'kjkj')]")]
        private IWebElement SendText { get; set; }

        #endregion
        public void SendingTextSteps()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Chat");
            SelectUser1.Click();
            TextBox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "TextMessage"));
            SendTab.Click();

        }


    }
}
