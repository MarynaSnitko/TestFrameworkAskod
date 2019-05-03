using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestFrameworkAskod.Pages
{
    public class OpenCardindexComponent : BasePage
    { 
        //[FindsBy(How = How.CssSelector, Using = "#imgBtnCard")]
        //public IWebElement fileManagerButton;

        //[FindsBy(How = How.CssSelector, Using = "#ctl00_VerticalMenuMaster_radTreeMenu > ul > li.rtLI.rtFirst > div > span.rtPlus")]
        //public IWebElement incomingCardsTreeButton;

        //[FindsBy(How = How.CssSelector, Using = "#ctl00_VerticalMenuMaster_radTreeMenu > ul > li.rtLI.rtFirst > ul > li:nth-child(2) > div > span.rtIn")]
        //public IWebElement incomingCardsCurrentBranch;

        //[FindsBy(How = How.CssSelector, Using = "#fullPathCard")]
        //public IWebElement bredCrumbsFilemanagerIncomingCurrent;

        public IWebElement fileManagerButton => Driver.FindElement(By.CssSelector("#imgBtnCard"));
        public IWebElement incomingCardsTreeButton => Driver.FindElement(By.CssSelector("#ctl00_VerticalMenuMaster_radTreeMenu > ul > li.rtLI.rtFirst > div > span.rtPlus"));
        public IWebElement incomingCardsCurrentBranch => Driver.FindElement(By.CssSelector("#ctl00_VerticalMenuMaster_radTreeMenu > ul > li.rtLI.rtFirst > ul > li:nth-child(2) > div > span.rtIn"));
        public IWebElement bredCrumbsFilemanagerIncomingCurrent => Driver.FindElement(By.CssSelector("#fullPathCard"));

        public OpenCardindexComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
