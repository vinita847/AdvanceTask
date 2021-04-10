using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class Dashboard
    {
        public Dashboard()
        {  
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }
        //webelements
        #region Webelements
        //Dashboard
        [FindsBy(How = How.LinkText, Using = "Dashboard")]
        private IWebElement DashBoardBtn { get; set; }

        //Select all Sign
        [FindsBy(How = How.XPath, Using = "//div[@class='ui icon basic button'][1]")]
        private IWebElement SelectAllSign { get; set; }

        //Serviceat index [2]
        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[2]")]
        private IWebElement CheckBoxsAtSecondEntry { get; set; }
        

        //Check Boxes
        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])")]
        private IList<IWebElement> CheckBoxs { get; set; }
        //private IWebElement CheckBox { get; set; }

           
        //All services
        [FindsBy(How = How.XPath, Using = "//i[@class='big tasks icon']")]
        private IList<IWebElement> Services { get; set; }



        //Delete Icon
        [FindsBy(How = How.XPath, Using = "//div//i[@class='trash icon']")]
        private IWebElement DeleteSign { get; set; }

        //Unselect all
        [FindsBy(How = How.XPath, Using = "//div//i[@class='ban icon']")]
        private IWebElement UnselectSign { get; set; }

        //Load More
        [FindsBy(How = How.XPath, Using = "//a[@class='ui button'][contains(text(), 'Load More')]")]
        private IWebElement LoadMoreTab { get; set; }

        //Mark as read
        [FindsBy(How = How.XPath, Using = "//div//i[@class='check square icon']")]
        private IWebElement MarkAsReadSign { get; set; }

        //Go to Page Link
        [FindsBy(How = How.XPath, Using = "//div[@class='ui link'][1]")]
        private IWebElement GoToPageLink { get; set; }
        //Go to Page Link
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]")]
        private IWebElement SuccessMsg { get; set; }

        #endregion

        public void SlectAll()
        {
         //click on dashboard
            DashBoardBtn.Click();
            //click on Select all
            Thread.Sleep(10000);
            SelectAllSign.Click();
            GlobalDefinitions.wait(10);
                               
        }
        public int CheckedServices()
        {
            int totalCheckedServices = CheckBoxs.Count();
            return totalCheckedServices;
        }
        public int AllServices()
        
        {
            int totalServices = Services.Count();
            return totalServices;
        }

        public void UnselectAllSteps()
        {
            Thread.Sleep(5000);
            //click on Unselect
            UnselectSign.Click();
        }

       
        public void LoadMoreSteps()
        {
            DashBoardBtn.Click();
            GlobalDefinitions.wait(30);
            LoadMoreTab.Click();
        }

        public string SuccessMessage()
        {
            string msg = SuccessMsg.Text;
            return msg;
        }

        public void MarkAsReadSteps()

        {
            DashBoardBtn.Click();
            Thread.Sleep(5000);
            CheckBoxsAtSecondEntry.Click();
            GlobalDefinitions.wait(30);

            MarkAsReadSign.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]"), 20);
        }

        public void DeleteNotificationSteps()
        {
            DashBoardBtn.Click();
            Thread.Sleep(5000);
            CheckBoxsAtSecondEntry.Click();
            GlobalDefinitions.wait(30);
            DeleteSign.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]"), 20);

        }




    }
}
