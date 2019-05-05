using OpenQA.Selenium;

namespace TestFrameworkAskod.Pages
{
    public class AskodHorizontalMenuComponent : BasePage
    {
        public IWebElement menuCard => Driver.FindElement(By.CssSelector("#menuCard a.menuLevel1"));
        public IWebElement menuMyRoom => Driver.FindElement(By.CssSelector("#menuMyRoom a.menuLevel1"));
        public IWebElement menuMyDoc => Driver.FindElement(By.CssSelector("#menuMyDoc a.menuLevel1"));
        public IWebElement menuDictionary => Driver.FindElement(By.CssSelector("#menuEdit a.menuLevel1"));
        public IWebElement menuReport => Driver.FindElement(By.CssSelector("#menuReport a.menuLevel1"));
        public IWebElement menuTeamwork => Driver.FindElement(By.CssSelector("#menuTeamwork a.menuLevel1"));
        public IWebElement menuTeamworkNew => Driver.FindElement(By.CssSelector("#menuTeamworkAlpha a.menuLevel1"));

        public AskodHorizontalMenuComponent(IWebDriver driver) : base(driver)
        {
        }

        public void ClickHorizontalMenuItem (IWebElement menuItem)
        {
            Actions.MoveToElement(menuItem).MoveByOffset(0, -2).Click().Perform();
        }
    }
}
