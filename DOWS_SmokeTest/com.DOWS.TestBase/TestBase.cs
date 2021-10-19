using DOWS_SmokeTest.com.DOWS.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DOWS_SmokeTest.com.DOWS.TestBase
{
    class TestBase
    {

        public static FileStream file;
        public static int rowNum = 1;

        public static IWebDriver driver;
        public string projectPath;
        public string chromeDriver;
        public string inputExcelPath;

        public TestBase()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            projectPath = new Uri(actualPath).LocalPath;
            chromeDriver = projectPath + "ChromeDriver";
        }
        public TestBase(IWebDriver _driver)
        {
            driver = _driver;
        }


        public void Initialization()
        {
            /* \n- new line
             \t - tab
             \r - carriage return
             \\ - back slash
             \" - double quote*/
            inputExcelPath = projectPath + "com.DOWS.TestDataAccess\\DOWS_TestData.xlsx";
            var data = ExcelReader.NewPopulateInCollection(@inputExcelPath);

            string Bname = ExcelReader.ReadData(rowNum, "Browsername", data);

            if (Bname.Equals("Chrome", StringComparison.OrdinalIgnoreCase))
            {

                ChromeOptions options = new ChromeOptions();
                //options.AddUserProfilePreference("download.default_directory", @"c:\downloads");
                options.AddArguments("test-type");
                options.AddArgument("--disable-popup-blocking");
                options.AddArgument("--ignore-certificate-errors");
                options.AddArguments("--disable-extensions");
                options.AddArguments("--start-maximized");
                options.AddArguments("download.default_directory");

                //options.AddArguments("");
                // options.ToCapabilities();
                driver = new ChromeDriver(@chromeDriver, options);
                driver.Manage().Window.Maximize();
                driver.Manage().Cookies.DeleteAllCookies();
                //driver.Manage().Timeouts().ImplicitWait.Add(System.TimeSpan.FromSeconds(5));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);

            }
            else if (Bname.Equals("IE", StringComparison.OrdinalIgnoreCase))
            {
                var options = new InternetExplorerOptions();
                options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                driver = new InternetExplorerDriver(@ConfigurationManager.AppSettings["IEDriverPath"], options);
                driver.Manage().Window.Maximize();
                driver.Manage().Cookies.DeleteAllCookies();
                //driver.Manage().Timeouts().ImplicitWait.Add(System.TimeSpan.FromSeconds(5));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);


            }
            else if (Bname.Equals("FireFox", StringComparison.OrdinalIgnoreCase))
            {
                var one = @ConfigurationManager.AppSettings["gechoDriver"];
                var two = @ConfigurationManager.AppSettings["gechoDriverPath"];
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(one, two);
                driver = new FirefoxDriver(service);
            }
        }

        public static string Capture(IWebDriver driver, string screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;

            string finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "FailedScreenShot/" + screenShotName + ".png";
            //string finalpth = pth + screenShotName + ".png";
            string localpath = new Uri(finalpth).LocalPath;
            screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
            return localpath;
        }
    }
}
