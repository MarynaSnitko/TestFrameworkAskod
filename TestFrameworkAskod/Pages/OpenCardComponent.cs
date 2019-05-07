using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestFrameworkAskod.Pages
{
    public class OpenCardComponent : BasePage
    { 
        public IWebElement EditRecordCardFilemanger => Driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_AskodGridCards_CommonGrid_ctl00__0 > td:nth-child(2) > input[type=image]"));
        public IWebElement CardTitle => Driver.FindElement(By.CssSelector("td.rwTitlebar td:nth-child(2) div"));

        public OpenCardComponent(IWebDriver driver) : base(driver)
        {
        }

        public void OpenIncomingCard()
        {
            EditRecordCardFilemanger.Click();
        }
    }
}
