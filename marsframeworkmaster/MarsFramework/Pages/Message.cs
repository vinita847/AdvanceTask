using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using MarsFramework.Global;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;

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

        //another User
        [FindsBy(How = How.XPath, Using = "(//div[contains(.,'simLastest chat row Lastest chat row Time')])[9]")]
        private IWebElement SelectUsersimi { get; set; }

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

        //IdeftifyFirstChatFRom Simi
        [FindsBy(How = How.XPath, Using = "(//span[contains(.,'hu')])[2]")]
        private IWebElement FirstTextSimi { get; set; }

        //select chatBox
        [FindsBy(How = How.CssSelector, Using = "#chatBox")]
        private IWebElement ChatBox { get; set; }
        //click enter to add the tag
        Actions enterBtn = new Actions(GlobalDefinitions.driver);


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

        public void UserSimi()
        {
            SelectUsersimi.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("(//span[contains(.,'hu')])[2]"), 10);

        }

        public void selectChatBox()
        {
            ChatBox.Click();
            enterBtn.SendKeys(Keys.ArrowUp).Perform();
            Thread.Sleep(10000);
            enterBtn.SendKeys(Keys.ArrowDown).Perform();
            Thread.Sleep(10000);

        }

        public string UserSimiFirstText()
        {
            string Text1 = FirstTextSimi.Text;
            return Text1;

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
