using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumTesting
{
    class Program
    {

        //Create Reference for the browser
        IWebDriver driver = new ChromeDriver();


        static void Main(string[] args)
        {

        }

        [SetUp]

        public void Initialize()
        {

            ////Navigate to SignUp
            //driver.Navigate().GoToUrl("https://www.linkedin.com/start/join?trk=hb_join");
            //Console.WriteLine("Opening the Browser.....");
            //Navigate to SignIn
            driver.Navigate().GoToUrl("https://www.linkedin.com/uas/login");
            Console.WriteLine("Opening the Browser.....");
            //Post an Article
            //driver.Navigate().GoToUrl("https://www.linkedin.com/feed/");
            //Console.WriteLine("Opening the Browser.....");


        }


        //[Test]

        //public void SignUp()
        //{
        //    Console.WriteLine("Executing Test.....");
        //    IWebElement firstNameElement = driver.FindElement(By.Name("firstName"));
        //    firstNameElement.SendKeys("Tony");
        //    IWebElement lastNameElement = driver.FindElement(By.Name("lastName"));
        //    lastNameElement.SendKeys("Parker");
        //    IWebElement emailAddressElement = driver.FindElement(By.Name("emailAddress"));
        //    emailAddressElement.SendKeys("ar989g@gmail.com");
        //    IWebElement passwordElement = driver.FindElement(By.Name("password"));
        //    passwordElement.SendKeys("Aenipainahch@9");
        //    IWebElement joinButtonElement = driver.FindElement(By.XPath("//*[@id=\"uno-reg-join\"]/div/div/div/div[2]/div[1]/div/div/form/fieldset/button/span"));
        //    joinButtonElement.Submit();

        //}

        //[Test]

        //public void SignIn()
        //{

        //    Console.WriteLine("Executing Test.....");
        //    IWebElement sessionKeyElement = driver.FindElement(By.Name("session_key"));
        //    sessionKeyElement.SendKeys("ar989g@gmail.com");
        //    IWebElement sessionPasswordElement = driver.FindElement(By.Name("session_password"));
        //    sessionPasswordElement.SendKeys("Aenipainahch@9");
        //    IWebElement signInButtonElement = driver.FindElement(By.Name("signin"));
        //    signInButtonElement.Submit();

        //}

        [Test]

        public void WriteAnArticle()
        {
            //SignIn
            Console.WriteLine("Executing Test.....");
            IWebElement sessionKeyElement = driver.FindElement(By.Name("session_key"));
            sessionKeyElement.SendKeys("ar989g@gmail.com");
            IWebElement sessionPasswordElement = driver.FindElement(By.Name("session_password"));
            sessionPasswordElement.SendKeys("Aenipainahch@9");
            IWebElement signInButtonElement = driver.FindElement(By.Name("signin"));
            signInButtonElement.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //Double Click the Share Field
            IWebElement postButtonElement = driver.FindElement(By.XPath("//*[@id=\"ember3471\"]")));
            postButtonElement.Click();
        }

        [TearDown]
        public void Cleanup()
        {
            Thread.Sleep(5000);
            driver.Close();
            Console.WriteLine("Closing the Browser.....");

        }

    }
}