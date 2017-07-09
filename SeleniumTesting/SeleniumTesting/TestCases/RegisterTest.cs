using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumTesting.PageObjects;

namespace SeleniumTesting.TestCases
{
    class RegisterTest
    {

        [Test]
        public void TestRegister()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.linkedin.com/start/join?trk=hb_join";
            var homePage = new RegisterPage();
            PageFactory.InitElements(driver, homePage);
            homePage.FirstNameElement.SendKeys("Tony");
            homePage.LastNameElement.SendKeys("Parker");
            homePage.EmailAddressElement.SendKeys("ar989g3@gmail.com");
            homePage.PasswordElement.SendKeys("Aenipainahch@9");
            homePage.JoinButtonElement.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            homePage.NumberInputElement.SendKeys("2025550172");
            homePage.SendCodeElement.Submit();
            driver.Close();

        }
    }
}
