using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumTesting.PageObjects;

namespace SeleniumTesting.TestCases
{
    class LogInTest
    {

        [Test]
        public void TestSignIn()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.linkedin.com/";
            var loginPage = new LogInPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("ar989g@gmail.com");
            loginPage.Password.SendKeys("Aenipainahch@9");
            loginPage.Submit.Submit();
            driver.Close();
        }
    }
}
