using MarsFramework.Config;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using System.IO;
using MarsFramework.Global;
using System.Threading;

namespace MarsFramework.Global
{
    [TestFixture]
    public class Base
    {
        #region To access Path from resource file


        public static int Browser = Int32.Parse(MarsResource.Browser);
        //public static string ExcelPath = MarsResource.ExcelPath;
        //public static string ScreenshotPath = MarsResource.ScreenShotPath;
        //public static string ReportPath = MarsResource.ReportPath;



        #endregion

        #region To access Dynamic paths

        // public static int Browser = Int32.Parse(MarsResource.Browser);

        // Excel path
        public static string ExcelPath = Directory.GetCurrentDirectory() + @"\MarsFramework\TestData\LogInData.xlsx";

        // Path to Save Screenshots

        public static string ScreenshotPath = Directory.GetCurrentDirectory() + @"\MarsFramework\TestReport1\Screenshots1\";


        // Report path

        //public static string ReportPath = Directory.GetCurrentDirectory() + @"\MarsFramework\TestReport1\TestReport.html";

        public static string ReportPath = Environment.CurrentDirectory + @"\MarsFramework\TestReport1\TestReport.html";

        // Report XML path
        
        public static string ReportXMLPath = Directory.GetCurrentDirectory() + "\\MarsFramework\\Config\\XMLFile.xml";
    
        #endregion



        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        #endregion

        #region setup and tear down
        [SetUp]
        public void Inititalize()
        {
           

            //advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/
            switch (Browser)
            {

                case 1:
                    GlobalDefinitions.driver = new FirefoxDriver();
                    break;
                case 2:
                    GlobalDefinitions.driver = new ChromeDriver();
                    GlobalDefinitions.driver.Manage().Window.Maximize();
                    break;
                    

            }
            //nevigate to home page
           GlobalDefinitions.driver.Navigate().GoToUrl("http://192.168.99.100:5000/Home");

            #region Initialise Reports

            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(ReportXMLPath);

            #endregion


            if (MarsResource.IsLogin == "true")
            {
                //Create Extent Report
                //test = extent.StartTest("Login Test");
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
                GlobalDefinitions.wait(30);
                //Thread.Sleep(10000);
                //try
                //{
                    
                //    string ExpectedUserName = "Hi vinita";
                //    //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                //    string ActualUserName = loginobj.ValidUserName.Text;
                //    Assert.AreEqual(ExpectedUserName, ActualUserName);
                //    Console.WriteLine($"User name is correct as Expected {ActualUserName}");
                //    //Base.test.Log(LogStatus.Pass, "Login Successful");

                //}
                //catch (NoSuchElementException)
                //{
                //  Console.Write("User Name not found");
                //  //test.Log(LogStatus.Fail, "Login Unsuccessful");

                //}



            }
            else
            {
                SignUp obj = new SignUp();
                obj.register();
            }

        }


        [TearDown]
        public void TearDown()
        {
            // Screenshot
            string img = GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Screenshot");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
            //ExtentTest test = extent.StartTest("My First Test", "Sample description");
            test.Log(LogStatus.Info, "Image example: " + img);
            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver :)            
            GlobalDefinitions.driver.Close();
            GlobalDefinitions.driver.Quit();
        }
        #endregion

    }
}