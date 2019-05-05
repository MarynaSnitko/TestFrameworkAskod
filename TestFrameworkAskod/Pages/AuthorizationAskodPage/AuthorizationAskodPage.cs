using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkAskod.Pages
{
    public class AuthorizationAskodPage : BasePage
    {
        //[FindsBy(How = How.CssSelector, Using = "#entLogin")]
        //public IWebElement loginField;

        //[FindsBy(How = How.CssSelector, Using = "#entPass")]
        //public IWebElement passwordField;

        //[FindsBy(How = How.CssSelector, Using = "#entButton")]
        //public IWebElement enterButton;

        public IWebElement LoginField => Driver.FindElement(By.CssSelector("#entLogin"));
        public IWebElement PasswordField => Driver.FindElement(By.CssSelector("#entPass"));
        public IWebElement EnterButton => Driver.FindElement(By.CssSelector("#entButton"));
        public IWebElement AskodTodayDataBlock => Driver.FindElement(By.CssSelector("#AskodTodayData"));
        public IWebElement ErrorMessageInvalidLogin => Driver.FindElement(By.CssSelector("[class='rwDialogPopup radalert'] div.rwDialogText"));
        // автогенеренный id


        public string validLogin = "тест 5";
        public string validPassword = "111";
        public string invalidLogin = "invalidLogin";
        public string invalidPassword = "invalidPassword";


        public AuthorizationAskodPage(IWebDriver driver) : base(driver)
        { 
        }

        public void Login(string login, string password)
        {
            LoginField.SendKeys(validLogin);
            PasswordField.SendKeys(validPassword);
            EnterButton.Click();
        }

        public void InvalidLogin(string login, string password)
        {
            LoginField.SendKeys(invalidLogin);
            PasswordField.SendKeys(invalidPassword);
            EnterButton.Click();
        }

    }
}
