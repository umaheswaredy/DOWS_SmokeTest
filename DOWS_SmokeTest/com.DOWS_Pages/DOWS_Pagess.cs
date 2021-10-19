using DOWS_SmokeTest.com.DOWS.PageFactorys;
using DOWS_SmokeTest.com.DOWS.TestBase;
using DOWS_SmokeTest.com.DOWS.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DOWS_SmokeTest.com.DOWS_Pages
{
    class DOWS_Pagess : TestBase
    {

        public ExtentReports extent;
        public ExtentTest test;
        public static int rowNum = 1;
        public static string leapFrog_uname = string.Empty;
        public static string leapFrog_pwd = string.Empty;
        public static string course_Name = string.Empty;
        public static string external_Education = string.Empty;
        public static string inputExcelPath;

        DOWS_Pages_Elements elements = new DOWS_Pages_Elements();

        public DOWS_Pagess()
        {
            PageFactory.InitElements(driver, elements);
        }

        public void Function_Change()
        {
            inputExcelPath = projectPath + "com.DOWS.TestDataAccess\\DOWS_TestData.xlsx";
            var data = ExcelReader.NewPopulateInCollection(@inputExcelPath);

            //Clicking function name dropdown
            elements.DOWS_FunctionName.Click();
            //Select and click function name
            elements.DOWS_FunctionName_Select.Click();

        }

        public void New_Course_Button()
        {
            //--//div[@class='c_headerfunction text-light']
            inputExcelPath = projectPath + "com.DOWS.TestDataAccess\\DOWS_TestData.xlsx";
            var data = ExcelReader.NewPopulateInCollection(@inputExcelPath);
            Console.WriteLine("New Course button going to click");
            Thread.Sleep(6000);
            elements.DOWS_CourseList_Tab.Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.XPath("//button[contains(text(),'Add Course')]"))));
            elements.DOWS_AddCourse_Tab.Click();
           // new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.XPath("//div/p[contains(text(),'Untitled course')]"))));
            Thread.Sleep(4000);
            //Enter Course Title
            elements.DOWS_EnterCoourse_Title.SendKeys(ExcelReader.ReadData(rowNum, "CourseTitle", data));
            Thread.Sleep(1000);
            elements.DOWS_EnterDLC_CourseNo.SendKeys(ExcelReader.ReadData(rowNum, "DLCCourseNo", data));

            /* Thread.Sleep(2000);
             elements.DOWS_SponsoredandDelivered.Click();
             Thread.Sleep(500);
             elements.DOWS_SponsoredandDelivered_Local.Click();*/
            Thread.Sleep(1000);

            //Select Sponsored dropdown value
            elements.DOWS_SponsoredandDelivered.Click();
            Thread.Sleep(1000);
            elements.DOWS_SponsoredandDelivered_Local.Click();
            Thread.Sleep(1000);
            //Select Delivery Type value
            elements.DOWS_DeliveryTypeDWDN.Click();
            Thread.Sleep(1000);
            elements.DOWS_DeliveryTypeDwdnValue.Click();
            Thread.Sleep(1000);
            elements.DOWS_DLCCourseStatusDwn.Click();
            Thread.Sleep(1000);
            elements.DOWS_DLCCourseStatusDwnValue.Click();
            Thread.Sleep(500);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 100)");

            //Select FIscal Year 
            elements.DOWS_FiscalYearDwn.Click();
            Thread.Sleep(500);
            elements.DOWS_FiscalYearDwnValue.Click();
            Thread.Sleep(500);
            //Select Learning Year 
            elements.DOWS_LearningYearDwn.Click();
            Thread.Sleep(500);
            elements.DOWS_LearningYearDwnValue.Click();
            Thread.Sleep(500);
            //Select Curriculum
            elements.DOWS_CurriculumDwn.Click();
            Thread.Sleep(500);
            elements.DOWS_CurriculumDwnValue.Click();
            Thread.Sleep(500);
            elements.DOWS_LocaleDwn.Click();
            Thread.Sleep(500);
            elements.DOWS_LocaleValue.Click();

            js.ExecuteScript("window.scrollTo(0, 300)");

            Thread.Sleep(500);
            elements.DOWS_LocaleServiceDwn.Click();
            Thread.Sleep(500);
            elements.DOWS_LocaleServiceLineValue.Click();
            Thread.Sleep(500);
            elements.DOWS_Cur_PortDwn.Click();
            Thread.Sleep(500);
            js.ExecuteScript("window.scrollTo(0, 300)");
            elements.DOWS_Cur_PortDwnValue.Click();
            Thread.Sleep(500);
            elements.DOWS_Program_SubTypeDwn.Click();
            Thread.Sleep(500);
            elements.DOWS_Program_SubTypeValue.Click();
            Thread.Sleep(500);
            js.ExecuteScript("window.scrollTo(0, 500)");
            elements.DOWS_LHours.SendKeys(ExcelReader.ReadData(rowNum, "LearningHours", data));
            Thread.Sleep(500);
            elements.DOWS_CPEHours.SendKeys(ExcelReader.ReadData(rowNum, "CPEHours", data));
            Thread.Sleep(500);
            elements.DOWS_ContentOwnerDwn.Click();
            Thread.Sleep(500);
            elements.DOWS_ContentOwner_Value.Click();
            Thread.Sleep(500);
            elements.DOWS_CreatedByVerder_Dwn.Click();
            Thread.Sleep(500);
            elements.DOWS_CreatedByVerder_Value.Click();
            Thread.Sleep(1500);
            elements.DOWS_ContentCreated.Click();
            Thread.Sleep(1000);
          //  string ccDateInput = ExcelReader.ReadData(rowNum, "ContentCreated", data);
           // Console.WriteLine("Content Created Date:: "+ ccDateInput);
            Thread.Sleep(1000);
            IList<IWebElement> ccDate = driver.FindElements(By.XPath("//tbody[@role='rowgroup']/tr/td/span"));
            Console.WriteLine(ccDate);
            foreach(var date in ccDate){
                string cDate = date.Text;
                if (cDate.Contains("15"))
                {
                    Console.WriteLine("Date selected : " +date);
                }
            }


            Thread.Sleep(500);
            elements.DOWS_ContentLast_Updated.Click();
            Thread.Sleep(500);
            js.ExecuteScript("window.scrollTo(0, 100)");
            elements.DOWS_Framework_Dwn.Click();
            Thread.Sleep(500);
            elements.DOWS_Framework_Value.Click();
            Thread.Sleep(500);
            elements.DOWS_Content_Link.SendKeys(ExcelReader.ReadData(rowNum, "ContentLink", data));
            Thread.Sleep(500);
            js.ExecuteScript("window.scrollTo(0, 100)");
            //Select GPS Group
            elements.DOWS_GPSGroup_Dwn.Click();
            Thread.Sleep(500);
            elements.DOWS_GPSGroup_Value.Click();
            Thread.Sleep(500);
            //Select GPS Tier
            elements.DOWS_GPSTier_Dwn.Click(); Thread.Sleep(500);
            elements.DOWS_GPSTier_Value.Click();
            Thread.Sleep(500);
            //Select First Delivery date
            elements.DOWS_FirstOfferingDate.SendKeys(ExcelReader.ReadData(rowNum, "DeliviryDay", data)); Thread.Sleep(500);
            elements.DOWS_MultipleOfferings.Click();
            Thread.Sleep(500);
            js.ExecuteScript("window.scrollTo(0, 500)");
            //select PPD Sponsor
            elements.DOWS_PPDSponsor_Dwn.Click(); Thread.Sleep(500);
            elements.DOWS_PPDSponsor_Value.Click();
            Thread.Sleep(500);
            elements.DOWS_Course_Reviewer.SendKeys(ExcelReader.ReadData(rowNum, "CourseReviewer", data));
            Thread.Sleep(500);
            //Held at Deloitte University check box
            elements.DOWS_HeldAtDeloitte.Click(); Thread.Sleep(500);
            //Enter Prerequisites data
            elements.DOWS_Prerequisites.SendKeys(ExcelReader.ReadData(rowNum, "Prerequisities", data)); Thread.Sleep(500);
            //Enter Advanced Preparation data
            elements.DOWS_AdvancedPreparation.SendKeys(ExcelReader.ReadData(rowNum, "AdvancedPreparation", data));
            Thread.Sleep(500);
            //Select New course and Standalone check boxes
            elements.DOWS_NewCourse_CheckBx.Click();
            Thread.Sleep(500);
            elements.DOWS_StandAlone_Course.Click();
            Thread.Sleep(500);
            //Select Course type dropdown
            elements.DOWS_Course_Type_Dwn.Click(); Thread.Sleep(500);
            elements.DOWS_Course_Type_Vale.Click();
            Thread.Sleep(500);
            //Course content status
            elements.DOWS_Course_Content_Status_Dwn.Click(); Thread.Sleep(500);
            elements.DOWS_Course_Content_Status_Value.Click();
            Thread.Sleep(500);
            //Planning Status
            elements.DOWS_Planning_status_Dwn.Click(); Thread.Sleep(500);
            elements.DOWS_Planning_status_Value.Click();




        }
        
    }
}
