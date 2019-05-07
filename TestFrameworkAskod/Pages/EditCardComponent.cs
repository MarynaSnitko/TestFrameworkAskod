using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkAskod.Pages
{
    public class EditCardComponent : BasePage
    {

        public IWebElement CorespondentOpeningDirectory => Driver.FindElement(By.CssSelector("#CardFormLoader_receivedCardForm_recivedCorrespondent_CorrespondentField_btnAC"));
        public IWebElement ContentField => Driver.FindElement(By.CssSelector("#CardFormLoader_receivedCardForm_recivedShortContent_ContentTextBox_txt"));

        public EditCardComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
