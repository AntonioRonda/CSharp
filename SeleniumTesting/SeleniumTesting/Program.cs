using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTesting
{
    class Program
    {

        private readonly IWebDriver _driver = new ChromeDriver();


        static void Main(string[] args)
        {
            Console.WriteLine("Running Final Assesment Selenium Testing in C#.....");
        }

        [OneTimeSetUp]

        public void Initialize()
        {
            _driver.Navigate().GoToUrl("https://www.linkedin.com/start/join?trk=hb_join");
            Console.WriteLine("Opening the Browser.....");
        }



        [Test]

        public void SignUpThruEmail()
        {
            Console.WriteLine("Executing Test SignUp Function.....");
            IWebElement firstNameElement = _driver.FindElement(By.Name("firstName"));
            firstNameElement.SendKeys("Tony");
            IWebElement lastNameElement = _driver.FindElement(By.Name("lastName"));
            lastNameElement.SendKeys("Parker");
            IWebElement emailAddressElement = _driver.FindElement(By.Name("emailAddress"));
            emailAddressElement.SendKeys("ar989g2@gmail.com");
            IWebElement passwordElement = _driver.FindElement(By.Name("password"));
            passwordElement.SendKeys("Aenipainahch@9");
            IWebElement joinButtonElement = _driver.FindElement(By.XPath("//*[@id=\"uno-reg-join\"]/div/div/div/div[2]/div[1]/div/div/form/fieldset/button/span"));
            joinButtonElement.Submit();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            IWebElement countryCodeElement = _driver.FindElement(By.Id("country-select"));
            var selectCountryElement = new SelectElement(countryCodeElement);
            selectCountryElement.SelectByValue("ph");
            IWebElement numberInputElement = _driver.FindElement(By.Name("number-input"));
            numberInputElement.SendKeys("9985928605");
            IWebElement sendCodeElement = _driver.FindElement(By.XPath("//*[@id=\"submitChallenge\"]"));
            sendCodeElement.Submit();

        }

        [Test]

        public void SignIn()
        {
            Console.WriteLine("Executing Test SignIn Function.....");
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
            Console.WriteLine("Executing Test WriteAnArticle Function.....");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement sharePostElement = _driver.FindElement(By.ClassName("sharing-share-box__post-button"));
            sharePostElement.SendKeys(Keys.Enter);
            IWebElement writePostElement = _driver.FindElement(By.ClassName("sharing-textarea__textarea--original"));
            writePostElement.SendKeys("Hello");
            IWebElement postElement = _driver.FindElement(By.ClassName("post"));
            postElement.SendKeys(Keys.Enter);
        }


        [Test]


        public void SearchPeople()
        {
            SignIn();
            Console.WriteLine("Executing Test SearchPeople Function.....");
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