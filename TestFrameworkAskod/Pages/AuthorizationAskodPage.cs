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
        public IWebElement passwordField => Driver.FindElement(By.CssSelector("#entPass"));
        public IWebElement enterButton => Driver.FindElement(By.CssSelector("#entButton"));

        public AuthorizationAskodPage(IWebDriver driver) : base(driver)
        { 
        }

    }
}
