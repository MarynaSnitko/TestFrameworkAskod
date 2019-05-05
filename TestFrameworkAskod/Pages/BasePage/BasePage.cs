using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkAskod.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;
        protected Actions Actions;
        

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Actions = new Actions(driver);
            PageFactory.InitElements(driver, this);
        }
    }
}
