using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTesting.PageObjects
{
    class LogInPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "session_key")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "session_password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login-submit")]
        public IWebElement Submit { get; set; }
    }
}
