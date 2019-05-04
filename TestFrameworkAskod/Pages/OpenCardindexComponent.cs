using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestFrameworkAskod.Pages
{
    public class OpenCardindexComponent : BasePage
    { 
        //[FindsBy(How = How.CssSelector, Using = "#ctl00_VerticalMenuMaster_radTreeMenu > ul > li.rtLI.rtFirst > div > span.rtPlus")]
        //public IWebElement incomingCardsTreeButton;

        //[FindsBy(How = How.CssSelector, Using = "#ctl00_VerticalMenuMaster_radTreeMenu > ul > li.rtLI.rtFirst > ul > li:nth-child(2) > div > span.rtIn")]
        //public IWebElement incomingCardsCurrentBranch;

        //[FindsBy(How = How.CssSelector, Using = "#fullPathCard")]
        //public IWebElement bredCrumbsFilemanagerIncomingCurrent;

        public IWebElement IncomingCardsTreeButton => Driver.FindElement(By.CssSelector("#ctl00_VerticalMenuMaster_radTreeMenu > ul > li.rtLI.rtFirst > div > span.rtPlus"));
        public IWebElement IncomingCardsCurrentBranch => Driver.FindElement(By.CssSelector("#ctl00_VerticalMenuMaster_radTreeMenu > ul > li.rtLI.rtFirst > ul > li:nth-child(2) > div > span.rtIn"));
        public IWebElement BredCrumbsFilemanagerIncomingCurrent => Driver.FindElement(By.CssSelector("#fullPathCard"));

        public OpenCardindexComponent(IWebDriver driver) : base(driver)
        {
        }

        public void OpenCardindexList()
        {
            IncomingCardsTreeButton.Click();
            IncomingCardsCurrentBranch.Click();
        }
    }
}
