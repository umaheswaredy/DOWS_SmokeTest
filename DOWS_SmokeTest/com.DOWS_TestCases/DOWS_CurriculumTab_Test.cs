using DOWS_SmokeTest.com.DOWS.TestBase;
using DOWS_SmokeTest.com.DOWS.Utils;
using DOWS_SmokeTest.com.DOWS_Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;

namespace DOWS_SmokeTest
{
    [TestFixture]
    class DOWS_Curriculum_Tab : TestBase
    {
        public ExtentReports extent;
        public ExtentTest test;
        public string inputExcelPath;



        [OneTimeSetUp]
        public void StartReport()
        {
            /* string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;3
             string actualPath = path.Substring(0, path.LastIndexOf("bin"));
             string projectPath = new Uri(actualPath).LocalPath;*/
            string reportPath = projectPath + "com.QA.Reports\\DOWS_CreateNewCourse.html";
            inputExcelPath = projectPath + "com.DOWS.TestDataAccess\\DOWS_TestData.xlsx";

            var data = ExcelReader.NewPopulateInCollection(@inputExcelPath);
            string QAname = ExcelReader.ReadData(rowNum, "User Name", data);
            extent = new ExtentReports(reportPath, true);
            extent.AddSystemInfo("Host Name", QAname)
            .AddSystemInfo("Environment", "QA")
            .AddSystemInfo("User Name", QAname);
            extent.LoadConfig(projectPath + "extent-config.xml");
        }

        [Test, Order(1)]
        public void OpenBrowser()
        {
            Initialization();
            test = extent.StartTest("OpenBrowser");
            test.Log(LogStatus.Info, "OpenBrowser");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test, Order(2)]
        public void LoginPage()
        {
            DOWS_Login_Page lpage = new DOWS_Login_Page();
            lpage.QDOWSLogin();
            test = extent.StartTest("Login URL");
            test.Log(LogStatus.Info, "Login URL");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test, Order(3)]
        public void Curriculum_Page()
        {
            DOWS_Login_Page curriculumpage = new DOWS_Login_Page();
            curriculumpage.Curriculum_tab();
            test = extent.StartTest("Click Curriculum tab");
            test.Log(LogStatus.Info, "Click Curriculum Tab");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void GetResult()
        {

            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                string screenshotPath = GetScreenshot.Capture(driver, "DOWS_CreateNewCourse");
                test.Log(LogStatus.Fail, stackTrace + errorMessage);
                test.Log(LogStatus.Fail, "Snapshot below" + test.AddScreenCapture(screenshotPath));
                Thread.Sleep(2000);
                extent.Flush();
                extent.Close();
            }
            if (status == TestStatus.Passed)
            {
                WriteExcelNew enew = new WriteExcelNew();
                var excelPath = @inputExcelPath;
                //var excelPath = @ConfigurationManager.AppSettings["ExcelData"];
                //Console.WriteLine(inputExcelPath);
                enew.Write(excelPath, "Two", 3, "Pass");
            }
            else if (status == TestStatus.Failed)
            {
                WriteExcelNew enew = new WriteExcelNew();
                // var excelPath = @ConfigurationManager.AppSettings["ExcelData"];
                var excelPath = @inputExcelPath;
                enew.Write(excelPath, "Two", 3, "Fail");
            }

            extent.EndTest(test);

        }

        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();
            extent.Close();

        }
    }
}
