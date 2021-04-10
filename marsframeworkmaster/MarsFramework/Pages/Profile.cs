using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using MarsFramework.Global;
using System.Threading;

namespace MarsFramework
{
    public class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        #region Profile Web Elements

        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "(//i[@class='right floated outline small write icon'])[1]")]
        private IWebElement AvailabilityTimeEdit { get; set; }


        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//option[@value='0']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //click on success message
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show'][contains(.,'Availability updated')]")]
        public IWebElement AvailabilitySuccessMsg { get; set; }

        //Click on Availability Hour icon
        [FindsBy(How = How.XPath, Using = "//strong[text()='Hours']//parent::span//following-sibling::div//i")]
        private IWebElement EditHoursIcon { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyHour']")]
        private IWebElement AvailabilityHours { get; set; }

        //Click on Earn Targets icon
        [FindsBy(How = How.XPath, Using = "//strong[text()='Earn Target']//parent::span//following-sibling::div//i")]
        private IWebElement EditEarnTargetsIcon { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//select[contains(@name,'availabiltyTarget')]")]
        private IWebElement EarnTargetDropDown { get; set; }

        #endregion

        #region Language Web Elements
        //Langauges 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Languages')]")]
        private IWebElement LanguageSection { get; set; }

        //add new button
        [FindsBy(How = How.XPath, Using = "(//div[contains(text(), 'Add New')][@class='ui teal button '])[1]")]
        private IWebElement AddNewButton { get; set; }

        //enter language field
        [FindsBy(How = How.Name, Using = ("name"))]
        private IWebElement EnterLanguage { get; set; }

        //select level field
        [FindsBy(How = How.Name, Using = ("level"))]
        private IWebElement LangLevelDD { get; set; }

        //add button
        [FindsBy(How = How.XPath, Using = ("//input[@type='button'][@value='Add']"))]
        private IWebElement AddButton { get; set; }

        //cancel button
        [FindsBy(How = How.XPath, Using = ("//input[@type='button'][@value='Cancel']"))]
        private IWebElement CancelLangButton { get; set; }

        //Language added success message
        [FindsBy(How = How.XPath, Using = ("//div[contains(@class,'ns-box-inner')]"))]
        public IWebElement LangAddedSuccessMsg { get; set; }

        #endregion

        #region Skill Web Elements


        //skill section
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Skills')]")]
        private IWebElement SkillsSection { get; set; }

        //Add new button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui teal button']")]
        private IWebElement AddNewBtnSkill { get; set; }


        //Add Skill Field 
        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        private IWebElement EnterSkillField { get; set; }

        //Skill Level
        [FindsBy(How = How.XPath, Using = "//select[@name='level']")]
        private IWebElement LevelSkillField { get; set; }

        //Add skill button
        [FindsBy(How = How.XPath, Using = "//input[@type='button'][@value='Add']")]
        private IWebElement AddSkillsButton { get; set; }

        //Dlete icon for skill
        [FindsBy(How = How.XPath, Using = "//td[contains(text(), 'Agile')]//following-sibling::td[2]//descendant::span[2]")]
        private IWebElement DeleteIcon { get; set; }

        //skill success msg
        //[FindsBy(How = How.XPath, Using = "//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]")]
        //private IWebElement SuccessMsg { get; set; }


        #endregion

        #region Education Web Elements
        //Education Section
        [FindsBy(How = How.XPath, Using = "//a[contains(@data-tab,'third')]")]
        private IWebElement EducationSection { get; set; }

        //AddNew button
        [FindsBy(How = How.XPath, Using = "(//div[@class='ui teal button '][contains(.,'Add New')])[2]")]
        private IWebElement EduAddNewEduBtn { get; set; }

        //Enter college
        [FindsBy(How = How.Name, Using = "instituteName")]
        private IWebElement EducationCollege { get; set; }

        //Enter Country
        [FindsBy(How = How.Name, Using = "country")]
        private IWebElement EducationCountry { get; set; }

        //Enter Title
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement EducationTitle { get; set; }

        //Enter Degree
        [FindsBy(How = How.Name, Using = "degree")]
        private IWebElement EducationDegree { get; set; }

        //Enter Year of Graduation
        [FindsBy(How = How.Name, Using = "yearOfGraduation")]
        private IWebElement EducationYear { get; set; }


        //Add Education btn
        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Add')]")]
        private IWebElement AddEduBtn { get; set; }

        //Edu Added Success msg
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]")]
        private IWebElement EducationAddedSuccessMsg { get; set; }



        #endregion

        #region Certification Web Elements

        //Ceritification section
        [FindsBy(How = How.XPath, Using = "//a[contains(@data-tab,'fourth')]")]
        private IWebElement CertificationSection { get; set; }


        //AddNewCertification
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'ui teal button ')])[3]")]
        private IWebElement AddNewCertification { get; set; }

        //CertificateName
        [FindsBy(How = How.Name, Using = "certificationName")]
        private IWebElement CertificateName { get; set; }

        //CerificateFrom
        [FindsBy(How = How.Name, Using = "certificationFrom")]
        private IWebElement CertificationFrom { get; set; }

        //CertificationYear
        [FindsBy(How = How.Name, Using = "certificationYear")]
        private IWebElement CertificationYear { get; set; }


        //CertificateAddBtn
        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Add')]")]
        private IWebElement CertificationAddBtn { get; set; }


        #endregion

        #region Descriprion Web Elements
        //Edit icon for Description
        [FindsBy(How = How.XPath, Using = "//h3[@class='ui dividing header']//i[@class='outline write icon']")]
        private IWebElement DescEditIcon { get; set; }

        //Enter data
        [FindsBy(How = How.XPath, Using = "//textarea[@name='value']")]
        private IWebElement DescriptionData { get; set; }

        //Save button
        [FindsBy(How = How.XPath, Using = "//button[contains(@type,'button')]")]
        private IWebElement SaveDesc { get; set; }

        //SuccessMsg for description
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]")]
        private IWebElement SaveDescriptionSuccessMsg { get; set; }

        #endregion

        #region Add new Skill Web Elements

        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseLang { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddLang { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/span/input[1]")]
        private IWebElement AddSkill { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement AddEdu { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[1]/div/input")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[1]/input")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddCerti { get; set; }

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        private IWebElement Save { get; set; }

        #endregion


        #region Change Password Web Elements
        //User Tab

        [FindsBy(How = How.XPath, Using = "//span[@class='item ui dropdown link ']")]
        private IWebElement UserNameTab { get; set; }

        //Click on Change Password
        [FindsBy(How = How.XPath, Using = "//span//div//a[2]")]
        private IWebElement ChangPwdTab { get; set; }

        //Current Password
        [FindsBy(How = How.Name, Using = "oldPassword")]
        private IWebElement CurrentPwd { get; set; }

        //New Password
        [FindsBy(How = How.Name, Using = "newPassword")]
        private IWebElement NewPwd { get; set; }

        //Confirm Password
        [FindsBy(How = How.Name, Using = "confirmPassword")]
        private IWebElement ConfirmPwd { get; set; }

        //Save button
        [FindsBy(How = How.XPath, Using = "//button[@type='button'][contains(.,'Save')]")]
        private IWebElement SavePwd { get; set; }

        //Success message
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement ChangePwdSuccessMsg { get; set; }



        #endregion


        #region Manage Requests
        //Manage request element
        [FindsBy(How = How.XPath, Using = "//div[@class='ui dropdown link item']")]
        private IWebElement ManageRequest { get; set; }

        //Received Request
        [FindsBy(How = How.LinkText, Using = "Received Requests")]
        private IWebElement ReceivedRequest { get; set; }

        //Sent Request
        [FindsBy(How = How.LinkText, Using = "Sent Requests")]
        private IWebElement SentRequest { get; set; }

        #endregion

       //Search Icon
        [FindsBy (How = How.XPath, Using = "//i[@class='search link icon']")]
        private IWebElement SearchIcon { get; set; }


        //Chat Icon Tab
        [FindsBy(How = How.LinkText, Using = " Chat")]
        private IWebElement ChatIcon { get; set; }

        #endregion



        public void EditAvailability()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");


            AvailabilityTimeEdit.Click();
            AvailabilityTime.Click();
            SelectElement availityOpt = new SelectElement(AvailabilityTime);
            // string avialbleOption = GlobalDefinitions.ExcelLib.ReadData(2, "Availability");
            availityOpt.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Availability"));
            Thread.Sleep(3000);
        }

        public void EditHours()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            EditHoursIcon.Click();
            AvailabilityHours.Click();

            SelectElement hoursOpt = new SelectElement(AvailabilityHours);
            // string avialbleOption = GlobalDefinitions.ExcelLib.ReadData(2, "Availability");
            hoursOpt.SelectByText(GlobalDefinitions.ExcelLib.ReadData(4, "Hours"));
            Thread.Sleep(3000);
        }

        public void EditEarnTargets()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            EditEarnTargetsIcon.Click();
            EarnTargetDropDown.Click();
            SelectElement earnTargets = new SelectElement(EarnTargetDropDown);
            earnTargets.SelectByText(GlobalDefinitions.ExcelLib.ReadData(4, "EarnTargets"));

            Thread.Sleep(3000);


        }
        public void AddLanguageSteps()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "LanguagesAndSkills");
            AddNewButton.Click();
            EnterLanguage.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));
            LangLevelDD.Click();
            SelectElement langLevel = new SelectElement(LangLevelDD);
            langLevel.SelectByValue(GlobalDefinitions.ExcelLib.ReadData(3, "Language Level"));
            AddButton.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]"), 10);
        }

        public void AddSkillSteps()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "LanguagesAndSkills");

            SkillsSection.Click();
            AddNewBtnSkill.Click();
            //AddNewButton.Click();
            EnterSkillField.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));
            LevelSkillField.Click();
            SelectElement selectLevel = new SelectElement(LevelSkillField);
            selectLevel.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Skill Level"));
            AddSkillsButton.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]"), 10);

        }

        public void AddEducationSteps()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Educations");
            EducationSection.Click();
            EduAddNewEduBtn.Click();
            EducationCollege.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "College/University"));
            Thread.Sleep(10000);
            EducationCountry.Click();
            SelectElement country = new SelectElement(EducationCountry);
            country.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Country of College/University"));
            EducationTitle.Click();
            SelectElement title = new SelectElement(EducationTitle);
            title.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            EducationDegree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));
            EducationYear.Click();
            SelectElement year = new SelectElement(EducationYear);
            year.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Year of graduation"));
            AddEduBtn.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]"), 10);

        }

        public void AddCertificationSteps()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certification");
            CertificationSection.Click();
            AddNewCertification.Click();
            CertificateName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));
            CertificationFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate From"));
            CertificationYear.Click();
            SelectElement year = new SelectElement(CertificationYear);
            year.SelectByValue(GlobalDefinitions.ExcelLib.ReadData(2, "Certification Year"));
            CertificationAddBtn.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]"), 10);
        }

        public void AddDescriptionSteps()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Description");

            DescEditIcon.Click();
            DescriptionData.Clear();
            DescriptionData.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            SaveDesc.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]"), 10);

        }

        public void ChangePwdSteps()
        {
            //initialize excel data reader
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ChangePassword");
            UserNameTab.Click();
            GlobalDefinitions.wait(10);
            ChangPwdTab.Click();
            //check if its an alert
            CurrentPwd.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Current Password"));
            NewPwd.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "New Password"));
            ConfirmPwd.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Confirm Password"));
            SavePwd.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')]"), 10);

        }

        public void ReceivedRequestsSteps()
        {
            ManageRequest.Click();
            ReceivedRequest.Click();
        }

        public void SentRequestsSteps()
        {
            ManageRequest.Click();
            SentRequest.Click();

         }

        public void ClickonSearch()
        {
            SearchIcon.Click();
            GlobalDefinitions.wait(10);
        }

        public void ClickonChatTab() => ChatIcon.Click();
    }
}
