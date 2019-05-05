using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestFrameworkAskod.Pages
{
    public class ToolbarCardindexComponent : BasePage
    {
        public IWebElement GenerateWordReport => Driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_AskodGridCards_CommonGrid_ctl00_ctl02_ctl00_btnReport > img"));
        public IWebElement TextMessageSuccessGenerateReport => Driver.FindElement(By.CssSelector("[class='rwWindowContent'] [class='rwDialogPopup radconfirm'] > div.rwDialogText"));
        //public IWebElement SubmitGenerateWordReport => Driver.FindElement(By.CssSelector("#ctl00_radWindowManager > div > [class='rwDialogPopup radconfirm'] [class='rwInnerSpan']"));

        public ToolbarCardindexComponent(IWebDriver driver) : base(driver)
        {
        }

        public void GenerateReport()
        {
            GenerateWordReport.Click();
            //SubmitGenerateWordReport.Click();
        }
    }
}
