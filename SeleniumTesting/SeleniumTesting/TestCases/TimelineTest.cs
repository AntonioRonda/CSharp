using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumTesting.PageObjects;

namespace SeleniumTesting.TestCases
{


    class TimelineTest
    {

        [Test]
        public void TestTimeline()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.linkedin.com/";
            driver.Manage().Window.Maximize();
            var loginPage = new LogInPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("ar989g@gmail.com");
            loginPage.Password.SendKeys("Aenipainahch@9");
            loginPage.Submit.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Manage().Window.Maximize();
            var writePost = new TimelinePage();
            writePost.SharePostElement.SendKeys(Keys.Enter);
            writePost.WritePostElement.SendKeys("Hello World!");
            writePost.PostButtonElement.SendKeys(Keys.Enter);
            driver.Close();
        }


    }
}
