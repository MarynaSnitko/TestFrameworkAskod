using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestFrameworkAskod.Pages
{
    public class OpenCardindexComponent : BasePage
    { 
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
