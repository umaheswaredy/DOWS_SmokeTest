using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOWS_SmokeTest.com.DOWS.PageFactorys
{
    class LoginPageFactory
    {
        [FindsBy(How = How.XPath, Using = "//input[@type='email']")]
        public IWebElement DOWS_UName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        public IWebElement DOWS_UName_submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='email']")]
        public IWebElement DOWS_UAlias { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/input[@id='userNameInput']")]
        public IWebElement DOWS_pwd { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Curriculum Management')]")]
        public IWebElement Curriculum_Tab { get; set; }
    }
}
