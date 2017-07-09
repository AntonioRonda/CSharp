using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTesting.PageObjects
{
    class TimelinePage
    {

        private IWebDriver driver;
        [FindsBy(How = How.ClassName, Using = "sharing-share-box__post-button")]
        public IWebElement SharePostElement { get; set; }
        [FindsBy(How = How.ClassName, Using = "sharing-textarea__textarea--original")]
        public IWebElement WritePostElement { get; set; }
        [FindsBy(How = How.ClassName, Using = "post")]
        public IWebElement PostButtonElement { get; set; }
    }
}
