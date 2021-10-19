using AutoIt;
using DOWS_SmokeTest.com.DOWS.PageFactorys;
using DOWS_SmokeTest.com.DOWS.TestBase;
using DOWS_SmokeTest.com.DOWS.Utils;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DOWS_SmokeTest.com.DOWS_Pages
{
    class DOWS_Login_Page : TestBase
    {

        public ExtentReports extent;
        public ExtentTest test;
        public static int rowNum = 1;
        public static string leapFrog_uname = string.Empty;
        public static string leapFrog_pwd = string.Empty;
        public static string course_Name = string.Empty;
        public static string external_Education = string.Empty;
        public static string inputExcelPath;
        
        LoginPageFactory login = new LoginPageFactory();

        public DOWS_Login_Page()
        {
            PageFactory.InitElements(driver, login);
        }

        public void QDOWSLogin()
        {
            inputExcelPath = projectPath + "com.DOWS.TestDataAccess\\DOWS_TestData.xlsx";
            var data = ExcelReader.NewPopulateInCollection(@inputExcelPath);

            //Entering QA DOWS URL
            driver.Url = ExcelReader.ReadData(rowNum, "QDOWSURL", data);
            Thread.Sleep(2000);
            Console.WriteLine("URL Opened");
            // LFQA.LF_UName.SendKeys(LFUserName);

            //Enter Email ID
            login.DOWS_UName.SendKeys(ExcelReader.ReadData(rowNum, "UserEmail", data));
            Thread.Sleep(500);
            login.DOWS_UName_submit.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Enter User Alias
            /*  login.DOWS_UAlias.SendKeys(ExcelReader.ReadData(rowNum, "UserName", data));
              //Enter Password
              login.DOWS_pwd.SendKeys(ExcelReader.ReadData(rowNum, "Password", data));*/

            //Enter User Alias
           /* AutoItX.Send("{uamudam}");
            AutoItX.Send("{tab}");
            AutoItX.Send("{Tech@#$%2345}");
            Thread.Sleep(1000);
            //login.ClickSubmit_btn();
            Thread.Sleep(6000);
            Console.WriteLine("After Submit button");*/

        }

        public void Curriculum_tab()
        {
            inputExcelPath = projectPath + "com.DOWS.TestDataAccess\\DOWS_TestData.xlsx";
            var data = ExcelReader.NewPopulateInCollection(@inputExcelPath);

            login.Curriculum_Tab.Click();
        }
    }
}
