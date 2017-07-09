using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumTesting.PageObjects;

namespace SeleniumTesting.TestCases
{
    class FollowPeopleTest
    {
        [Test]
        public void TestFollowPage()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.linkedin.com/";
            var loginPage = new LogInPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("ar989g@gmail.com");
            loginPage.Password.SendKeys("Aenipainahch@9");
            loginPage.Submit.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            var follow = new FollowPage();
            follow.SearchFieldElement.SendKeys("Edzen Mark Cervito");
            follow.NavigateSearchButtonElement.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            follow.ActorNameElement.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Actions actions = new Actions(driver);
            actions.MoveToElement(follow.FollowButtonElement).Click().Perform();
            driver.Close();

        }
    }
}
