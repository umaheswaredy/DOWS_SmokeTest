using OpenQA.Selenium;
using System;

namespace DOWS_SmokeTest.com.DOWS.TestBase
{
    class GetScreenshot
    {
        public static string Capture(IWebDriver driver, string screenshotFirstName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenShot = ts.GetScreenshot();
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string finalPath = pth.Substring(0, pth.LastIndexOf("bin")) + "ErrorScreenshots\\" + screenshotFirstName + ".Png";
            string localPath = new Uri(finalPath).LocalPath;
            //screenShot.SaveAsFile(@"C:\\ProjectData\\LeapFrog\\LeapFrogSanity\\LeapFrogSanity\FailScreenShot\\TestOne"+one+".Png", OpenQA.Selenium.ScreenshotImageFormat.Png);
            screenShot.SaveAsFile(localPath, OpenQA.Selenium.ScreenshotImageFormat.Png);
            return localPath;

        }
    }
}
