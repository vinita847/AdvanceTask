using MarsFramework.Pages;
using NUnit.Framework;
using System.Collections.Generic;
using MarsFramework.Global;
using System;
using System.Threading;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace MarsFramework
{
    class Program 
    {
        [TestFixture]
        [Category("Sprint1")]      

        public class User : Base

        {
           //Profile proileObj = new Profile();
            public object ExcelLib { get; private set; }
            [Test]
            public void AddAvailability()
            {

                Profile proileObj = new Profile();
                proileObj.EditAvailability();                            
               
                //start report
                test = extent.StartTest("Edit Availability Test");


                try
                {
                    //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')"), 20);

                    string ActualMessage = proileObj.AvailabilitySuccessMsg.Text;
                    string ExpectedMsg = "Availability updated";
                    Assert.AreEqual(ExpectedMsg, ActualMessage);
                    //log the test
                    test.Log(LogStatus.Pass, "Test Pass, Availability Updated");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Availability");
                    Console.WriteLine("Test Passed:" + " " + ActualMessage);
                }
                catch (Exception e)
                {
                    Global.Base.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                    Console.WriteLine("Test Failed");
                }
            }
            [Test]
            public void AddHours()
            {
                Profile proileObj = new Profile();
                proileObj.EditHours();

                //start report
                test = extent.StartTest("Edit Hours Test");
                try
                {
                    //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')"), 20);

                    string ActualMessage = proileObj.AvailabilitySuccessMsg.Text;
                    string ExpectedMsg = "Availability updated";
                    Assert.AreEqual(ExpectedMsg, ActualMessage);
                    //log the test
                    test.Log(LogStatus.Pass, "Test Pass, Hours Updated");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Hours");
                    Console.WriteLine("Test Passed:" + " " + ActualMessage);
                }
                catch (Exception e)
                {
                    Global.Base.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                    Console.WriteLine("Test Failed");
                }

                               
            }
            [Test]
            public void AddEarnTargets()
            {
                //create an object of the page
                Profile proileObj = new Profile();
                test = extent.StartTest("Edit EarnTargets Test");
                proileObj.EditEarnTargets();
                //start report
                

                try
                {
                    //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')"), 20);

                    string ActualMessage = proileObj.AvailabilitySuccessMsg.Text;
                    string ExpectedMsg = "Availability updated";
                    Assert.AreEqual(ExpectedMsg, ActualMessage);
                    //log the test
                    test.Log(LogStatus.Pass, "Test Pass, Earn Target Updated");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Earn Targets");
                    Console.WriteLine("Test Passed:" + " " + ActualMessage);
                }
                catch (Exception e)
                {
                    Global.Base.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                    Console.WriteLine("Test Failed");
                }

            }

            [Test]
            public void AddLanguage()
            {
                test = extent.StartTest("Add a Language test");
                Profile profileObj = new Profile();
                profileObj.AddLanguageSteps();
                try
                { 
                string ExpectedMsg = "Punjabi has been added to your languages";
                string ActualMsg = profileObj.LangAddedSuccessMsg.Text;
                Assert.AreEqual(ExpectedMsg, ActualMsg);
                test.Log(LogStatus.Pass, "Test Pass: Language added to the list");
                GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Language Added");

                    Console.WriteLine(ExpectedMsg);
                }

                catch (NoSuchElementException)
                {
                    Console.Write("Langauges not added");
                    test.Log(LogStatus.Fail, "Test Failed");

                }

            }

            [Test]
            public void AddASkill()
            {
                test = extent.StartTest("Add a Skill Test");
                Profile profile = new Profile();
                profile.AddSkillSteps();
                try
                {
                    string ExpectedMsg = "Cucumber has been added to your skills";
                    string ActualMsg = profile.LangAddedSuccessMsg.Text;
                    Assert.AreEqual(ExpectedMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Skill added to the list");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Skill Added");

                    Console.WriteLine(ExpectedMsg);

                }
                catch(NoSuchElementException)
                {
                    Console.Write("Skill not added");
                    test.Log(LogStatus.Fail, "Test Failed");
                }

            }
            [Test]
            public void AddEducation()
            {
                test = extent.StartTest("Add Education Test");
                Profile profile = new Profile();
                profile.AddEducationSteps();
                try
                {
                    string ExpectedMsg = "Education has been added";
                    string ActualMsg = profile.LangAddedSuccessMsg.Text;
                    Assert.AreEqual(ExpectedMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Education added to the list");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Education Added");

                    Console.WriteLine(ExpectedMsg);

                }
                catch (NoSuchElementException)
                {
                    Console.Write("Education not added");
                    test.Log(LogStatus.Fail, "Test Failed");
                }

            }

            [Test]
            public void AddCertificate()
            {
                test = extent.StartTest("Add Certification Test");
                Profile proObj = new Profile();
                proObj.AddCertificationSteps();
                try
                {
                    string ExpectedMsg = "ISTQB has been added to your certification";
                    string ActualMsg = proObj.LangAddedSuccessMsg.Text;
                    Assert.AreEqual(ExpectedMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Certification added to the list");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Certification Added");

                    Console.WriteLine(ExpectedMsg);

                }
                catch (NoSuchElementException)
                {
                    Console.Write("Certificate not added");
                    test.Log(LogStatus.Fail, "Test Failed");
                }


            }

            [Test]
            public void AddDescription()
            {
                test = extent.StartTest("Add Description Test");
                Profile proObj = new Profile();
                proObj.AddDescriptionSteps();
                try
                {
                    string ExpectedMsg = "Description has been saved successfully";
                    string ActualMsg = proObj.LangAddedSuccessMsg.Text;
                    Assert.AreEqual(ExpectedMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Description added to the list");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Description Added");

                    Console.WriteLine(ExpectedMsg);

                }
                catch (NoSuchElementException)
                {
                    Console.Write("Description not added");
                    test.Log(LogStatus.Fail, "Test Failed");
                }
            }

            [Test]
            public void AddSkill()
            
            {
                ShareSkill AddShareSkill = new ShareSkill();
                AddShareSkill.AddSkill();
                //Thread.Sleep(2000);
                try
                {
                    string ExpectedMsg = "Service Listing Added successfully";
                    GlobalDefinitions.wait(10);
                    string ActulaMsg = AddShareSkill.SkillAddedSuccessMsg.Text;
                    GlobalDefinitions.wait(10);

                    Assert.AreEqual(ExpectedMsg, ActulaMsg);
                    Console.WriteLine(ExpectedMsg);

                }
                catch (NoSuchElementException)
                {
                    Console.Write("Skill Add element not found");
                }

                
            }

            [Test]
            public void UpdateSkill()
            {
                ManageListings SkillEdit = new ManageListings();
                SkillEdit.EditExistingSkill();

                try
                {
                    string ExpectedUpdateMsg = "Service Listing Updated successfully";
                    GlobalDefinitions.wait(20);

                    string ActualMsg = SkillEdit.SuccessMsg.Text;
                    GlobalDefinitions.wait(10);

                    Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
                    Console.WriteLine(ExpectedUpdateMsg);

                }
                catch (NoSuchElementException)
                {
                    Console.Write("Skill Update element not found");
                }
            }


            [Test]

            public void DeleteSkill()
            {
                ManageListings SkillDelete = new ManageListings();
                SkillDelete.DeleteExistingSkill();
                //Thread.Sleep(2000);
                string ExpectedUpdateMsg = "Selenium has been deleted";
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                string ActualMsg = SkillDelete.SuccessMsg.Text;

                Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
                Console.WriteLine(ExpectedUpdateMsg);
            }

            [Test]
            public void ChangePassword()
            {
                test = extent.StartTest("Change Password");
                Profile proObj = new Profile();
                proObj.ChangePwdSteps();


                try
                {
                    string ExpectedUpdateMsg = "Password Changed Successfully";
                    GlobalDefinitions.wait(20);

                    string ActualMsg = proObj.AvailabilitySuccessMsg.Text;                       
                    GlobalDefinitions.wait(10);

                    Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Password changed successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Password Changed");

                    Console.WriteLine(ExpectedUpdateMsg);

                }
                catch (NoSuchElementException)
                {
                    Console.Write("Test Failed");
                    test.Log(LogStatus.Fail, "Test Failed");

                }
            }

            [Test]
            public void ReceiveRequestAccept()
            {
                 
                test = extent.StartTest("Accept a Received request");
                Profile proObj = new Profile();
                proObj.ReceivedRequestsSteps();
                ReceivedRequests recReqObj = new ReceivedRequests();
                recReqObj.RequestAccept();
                //recReqObj.RequestCompleted();

                try
                {
                    string ExpectedUpdateMsg = "Service has been updated";
                    GlobalDefinitions.wait(20);

                    string ActualMsg = recReqObj.ReqSuccessMsg.Text;
                    GlobalDefinitions.wait(10);

                    Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Request accepted successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Request Accepted");

                    Console.WriteLine(ExpectedUpdateMsg);              


                }
                catch (NoSuchElementException)
                {
                    Console.Write("Element not found");
                }




            }

            [Test]
            public void ReceiveRequestDecline()
            {
                test = extent.StartTest("Decline a Received request");
                Profile proObj = new Profile();
                proObj.ReceivedRequestsSteps();
                ReceivedRequests recReqObj = new ReceivedRequests();
                recReqObj.RequestDecline();
                //recReqObj.RequestCompleted();

                try
                {
                    string ExpectedUpdateMsg = "Service has been updated";
                    GlobalDefinitions.wait(20);

                    string ActualMsg = recReqObj.ReqSuccessMsg.Text;
                    GlobalDefinitions.wait(10);

                    Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Request Declined successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Request Declined");

                    Console.WriteLine(ExpectedUpdateMsg);


                }
                catch (NoSuchElementException)
                {
                    Console.Write("Element not found");
                }
            }
            [Test]
            public void WithdrawSentRequest()
            {
                test = extent.StartTest("Request Sent Test");
                Profile proObj = new Profile();
                proObj.SentRequestsSteps();
                SentRequests sentReqObj = new SentRequests();
                sentReqObj.WithdrawSentRequest();

                try
                {
                    string ExpectedUpdateMsg = "Request has been withdrawn";
                    GlobalDefinitions.wait(20);

                    string ActualMsg = proObj.LangAddedSuccessMsg.Text;
                    GlobalDefinitions.wait(10);

                    Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Request Withdrwn successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Request Withdraw");

                    Console.WriteLine(ExpectedUpdateMsg);


                }

                catch (NoSuchElementException)
                {
                    Console.Write("Element not found");

                }

            }
            [Test]
            public void SeachCategory()
            {
                test = extent.StartTest("Test for search by category: Music & Audio");
                Profile proObj = new Profile();
                GlobalDefinitions.wait(10);
                proObj.ClickonSearch();
                GlobalDefinitions.wait(10);

                Search searchObj = new Search();
                searchObj.SearchSkillByCatg();
                GlobalDefinitions.wait(10);

                try
                {
                var actualValue = searchObj.CategoryMusic.Text;
                var expectedValue = "41";
                 
                Assert.AreEqual(actualValue, expectedValue);
                Console.WriteLine("Test pass");
                test.Log(LogStatus.Pass, "Test Pass");
                GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Request Withdraw");

                }
                catch (ElementNotVisibleException)
                {
                    Console.WriteLine("Test failed");
                    test.Log(LogStatus.Fail, "Test Failed");

                }


            }
            [Test]
            public void FilterByOnline()
            {
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Filter");
                test = extent.StartTest("Test for Filter skills by Online option");
                try
                {
                Profile profileObj = new Profile();
                profileObj.ClickonSearch();
                Search SearchObj = new Search();
                SearchObj.FilterOnline();
                GlobalDefinitions.wait(20);
                var ActualCount = SearchObj.TotalSkillCount.Text;

                GlobalDefinitions.wait(20);
                  //Assert.AreEqual("1154", ActualCount);
                Assert.That(ActualCount, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Online")));
                Console.WriteLine("Test pass");
                test.Log(LogStatus.Pass, "Test Pass");
                GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Filter by Online");
                }
                catch(ElementNotVisibleException)
                {
                    Console.WriteLine("Test Failed");
                    test.Log(LogStatus.Fail, "Test Failed");

                }


            }
            [Test]
            public void FilterByOnsite()
            {
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Filter");
                test = extent.StartTest("Test for Filter skills by Online option");
                try
                {
                    Profile profileObj = new Profile();
                    profileObj.ClickonSearch();
                    Search SearchObj = new Search();
                    SearchObj.FilterOnsite();
                    GlobalDefinitions.wait(10);

                    string ActualCount = SearchObj.TotalSkillCount.Text;

                    GlobalDefinitions.wait(10);
                    //var ActualCount = SearchObj.TotalSkillCount.Text;

                    var ExpectedCount = 310;
                    Assert.AreEqual(ExpectedCount, ActualCount);
                    //Assert.That(SearchObj.TotalSkills(), Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Onsite")));
                    Console.WriteLine("Test pass: User is able to find the Onsite skills");
                    test.Log(LogStatus.Pass, "Test Pass");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Filter by Online");


                }

                catch (NoSuchElementException)
                {
                    Console.WriteLine("Test Failed");
                    test.Log(LogStatus.Fail, "Test Failed");

                }



            }
            [Test] //incomplete
            public void ShowAllFiter()
            {
                Search SearchObj = new Search();
                SearchObj.ShowAll();
            }

            [Test]
            public void SelectAllNotifications()
            {
                test = extent.StartTest("Select All Option for Notifications");
                Dashboard dashboardObj = new Dashboard();
                dashboardObj.SlectAll();
                int ActualValue = dashboardObj.TotalCheckedServices();
                int Expectedvalue = dashboardObj.TotalCheckBoxes();
               
                try { 
               Assert.AreEqual(Expectedvalue, ActualValue);

               test.Log(LogStatus.Pass, "Test Pass: All Checkboxes selected");
               GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Select All");
               Console.WriteLine("Test Pass : All notifications are selected");

                }
                catch(Exception e)
                {
                    test.Log(LogStatus.Fail, "Test failed");
                    Console.WriteLine(e + "Test Failed");
                }

            }
            [Test]
            public void UnSelectAllNotifications()
            {
                test = extent.StartTest("Test for Unselect all checkboxes");
                Dashboard dashboardObj = new Dashboard();
                dashboardObj.SlectAll();
                dashboardObj.UnselectAllSteps();
                int ActualValue = dashboardObj.TotalCheckedServices();
                int Expectedvalue = dashboardObj.TotalCheckBoxes();

                try
                {
                    Assert.AreEqual(Expectedvalue, ActualValue);
                    test.Log(LogStatus.Pass, "All Services unselected");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "UnSelect all services");
                    Console.WriteLine("Test Passed: All checkboxes unselected");
                }
                catch(Exception e)
                {
                    test.Log(LogStatus.Fail, "Services not selected");
                    Console.WriteLine( e +  "Test Failed: Checkboxes not selected");
                }


            }

            [Test] 
            public void LoadMoreForNotification()
            {
                test = extent.StartTest("Test for Load More functionality for Notifications");
                Dashboard dashboardObj = new Dashboard();
                dashboardObj.LoadMoreSteps();
                Thread.Sleep(10000);
                //bool ActualCount = dashboardObj.AllServices();
                int ActualCount = dashboardObj.AllServices();
                try
                {                   
                    Assert.Greater(ActualCount, 5);

                    test.Log(LogStatus.Pass, "Able to load more Services");
                    Console.WriteLine("Test Pass: Able to cick on Load More tab");

                }
                catch(Exception e)
                {
                    test.Log(LogStatus.Fail, "Not able to click on Load More tab");
                    Console.WriteLine(e + "Test failed: can not clcick on Load More tab");
                }
                
            }

            [Test]
            public void ShowLessForNotification()
            {
                test = extent.StartTest("Test for Show Less functionality for Notifications");
                Dashboard dashboardObj = new Dashboard();
                dashboardObj.LoadMoreSteps();
                dashboardObj.ClickOnShowLessStep();
                int ActualCount = dashboardObj.AllServices();
                try
                {
                    Assert.That(ActualCount > 0);
                    //Assert.AreEqual(ActualCount, 5);

                    test.Log(LogStatus.Pass, "Able to load Less Services by clicking on Show Less Tab");
                    Console.WriteLine("Test Pass: Able to cick on Show Less tab");

                }
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, "Not able to click on Show Less tab");
                    Console.WriteLine(e + "Test failed: can not clcick on Show Less tab");
                }

            }


            [Test]
           public void MarkAsRead()
            {
                test = extent.StartTest("Mark as read for notifications");
                Dashboard dashboardObj = new Dashboard();
                dashboardObj.MarkAsReadSteps();
                string ActualMsg = dashboardObj.SuccessMessage();
                string ExpectedMsg = "Notification updated";
                try
                {
                    Assert.AreEqual(ExpectedMsg, ActualMsg);
                    test.Log(LogStatus.Pass, ("Test passed: Service is marked as read"));
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Selected service is Mark as read");
                    Console.WriteLine("Test passed: Service is marked as read");
                }
                catch(Exception e)
                {
                    test.Log(LogStatus.Fail, "Services is not marked as read");
                    Console.WriteLine(e + "Test Failed: not selected as Mark as Read");
                }




            }

           [Test]
           public void DeleteNotification()
            {
                test = extent.StartTest("Delete for notifications");
                Dashboard dashboardObj = new Dashboard();
                dashboardObj.DeleteNotificationSteps();
                string ActualMsg = dashboardObj.SuccessMessage();
                string ExpectedMsg = "Notification updated";
                try
                {
                    Assert.AreEqual(ExpectedMsg, ActualMsg);
                    test.Log(LogStatus.Pass, ("Test passed: Service is Deleted Successfully"));
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Selected service is Deleted");
                    Console.WriteLine("Test passed: Service is Deleted");
                }
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, "Service is not deleted");
                    Console.WriteLine(e.Message + "Test Failed");
                }
            }
            [Test]
            public void Chat()
            {
                test = extent.StartTest("Varifying test functionality for a specific user");
               
                Profile profileObj = new Profile();
                profileObj.ClickonChatTab();
                Message msgObj = new Message();
                msgObj.SendingTextSteps();
                string ActualMsg = msgObj.ExpectedMsg();
                string ExpectedMsg = "Text message";
                //int oldCount = msgObj.LatestText();
                //int newCount = msgObj.LatestText() + 1;
                //Assert.IsTrue(newCount > oldCount, "Icremented by 1");
                try
                {

                    Assert.AreEqual(ExpectedMsg, ActualMsg);
                    test.Log(LogStatus.Pass, ("Test Passed: User is able to send a message to other user"));
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Sending a message via Chat");
                    Console.WriteLine("Test Pass: Message is sent");
                }
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, ("Test Passed: User is not able to send a message to other user"));
                    Console.WriteLine("Test Faild: Message is not sent" + e.Message);
                }


            }
        }



        
    }
}