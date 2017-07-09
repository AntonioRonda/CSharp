using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTesting.PageObjects
{
    class FollowPage
    {

        private IWebDriver driver;
        [FindsBy(How = How.ClassName, Using = "ember-text-field")]
        public IWebElement SearchFieldElement { get; set; }
        [FindsBy(How = How.ClassName, Using = "nav-search-button")]
        public IWebElement NavigateSearchButtonElement { get; set; }
        [FindsBy(How = How.PartialLinkText, Using = "Edzen Mark Cervito")]
        public IWebElement ActorNameElement { get; set; }
        [FindsBy(How = How.ClassName, Using = "pv-recent-activity-section__follow-button")]
        public IWebElement FollowButtonElement { get; set; }
            
    }
}
