using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTesting.PageObjects
{
    class RegisterPage
    {
            private IWebDriver driver;
            [FindsBy(How = How.Name, Using = "firstName")]
            public IWebElement FirstNameElement { get; set; }
            [FindsBy(How = How.Name, Using = "lastName")]
            public IWebElement LastNameElement { get; set; }
            [FindsBy(How = How.Name, Using = "emailAddress")]
            public IWebElement EmailAddressElement { get; set; }
            [FindsBy(How = How.Name, Using = "password")]
            public IWebElement PasswordElement { get; set; }
            [FindsBy(How = How.XPath, Using = "//*[@id=\"uno-reg-join\"]/div/div/div/div[2]/div[1]/div/div/form/fieldset/button/span")]
            public IWebElement JoinButtonElement { get; set; }
            [FindsBy(How = How.Id, Using = "country-select")]
            public IWebElement CountryCodeElement { get; set; }
            [FindsBy(How = How.Name, Using = "number-input")]
            public IWebElement NumberInputElement { get; set; }
            [FindsBy(How = How.XPath, Using = "//*[@id=\"submitChallenge\"]")]
            public IWebElement SendCodeElement { get; set; }

    }
}
