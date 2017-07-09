using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTesting
{
    class Program
    {

        //Create Reference for the browser


        private readonly IWebDriver _driver = new ChromeDriver();

        
        static void Main(string[] args)
        {

        }

        [OneTimeSetUp]

        public void Initialize()
        {

            //Navigate to SignUp
            _driver.Navigate().GoToUrl("https://www.linkedin.com/start/join?trk=hb_join");
            Console.WriteLine("Opening the Browser.....");
        }



        [Test]

        public void SignUpThruEmail()
        {
            Console.WriteLine("Executing Test SignUp.....");
            IWebElement firstNameElement = _driver.FindElement(By.Name("firstName"));
            firstNameElement.SendKeys("Tony");
            IWebElement lastNameElement = _driver.FindElement(By.Name("lastName"));
            lastNameElement.SendKeys("Parker");
            IWebElement emailAddressElement = _driver.FindElement(By.Name("emailAddress"));
            emailAddressElement.SendKeys("ar989g1@gmail.com");
            IWebElement passwordElement = _driver.FindElement(By.Name("password"));
            passwordElement.SendKeys("Aenipainahch@9");
            IWebElement joinButtonElement = _driver.FindElement(By.XPath("//*[@id=\"uno-reg-join\"]/div/div/div/div[2]/div[1]/div/div/form/fieldset/button/span"));
            joinButtonElement.Submit();
            IWebElement countryCodeElement = _driver.FindElement(By.Name("countryCode"));
            var selectElement = new SelectElement(countryCodeElement);
            selectElement.SelectByIndex(167);
        }

        [Test]

        public void SignIn()
        {
            Console.WriteLine("Executing Test SignIn.....");
            _driver.Navigate().GoToUrl("https://www.linkedin.com/uas/login");
            Console.WriteLine("Opening the Browser.....");
            IWebElement sessionKeyElement = _driver.FindElement(By.Name("session_key"));
            sessionKeyElement.SendKeys("ar989g@gmail.com");
            IWebElement sessionPasswordElement = _driver.FindElement(By.Name("session_password"));
            sessionPasswordElement.SendKeys("Aenipainahch@9");
            IWebElement signInButtonElement = _driver.FindElement(By.Name("signin"));
            signInButtonElement.Submit();
        }




        [Test]

        public void WriteAnArticle()
        {
            SignIn();
            Console.WriteLine("Executing Test WriteAnArticle.....");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement sharePostElement = _driver.FindElement(By.ClassName("sharing-share-box__post-button"));
            sharePostElement.SendKeys(Keys.Enter);
            IWebElement writePostElement = _driver.FindElement(By.ClassName("sharing-textarea__textarea--original"));
            writePostElement.SendKeys("Hello");
            IWebElement postElement = _driver.FindElement(By.ClassName("post"));
            postElement.SendKeys(Keys.Enter);
        }


        [Test]


        public void SearchConnection()
        {
            SignIn();
            Console.WriteLine("Executing Test SearchConnection.....");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement searchFieldElement = _driver.FindElement(By.ClassName("ember-text-field"));
            searchFieldElement.SendKeys("Antonio Santos Ronda Jr.");
            IWebElement navigateSearchButtonElement = _driver.FindElement(By.ClassName("nav-search-button"));
            navigateSearchButtonElement.SendKeys(Keys.Enter);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement actorNameElement = _driver.FindElement(By.PartialLinkText("Antonio Santos Ronda Jr."));
            actorNameElement.Click();

        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Close();
            Console.WriteLine("Closing the Browser.....");
        }

    }

}