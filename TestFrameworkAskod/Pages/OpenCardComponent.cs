﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestFrameworkAskod.Pages
{
    public class OpenCardComponent : BasePage
    {
        //[FindsBy(How = How.CssSelector, Using = "#ctl00_ContentPlaceHolder1_AskodGridCards_CommonGrid_ctl00__0 > td:nth-child(2) > input[type=image]")]
        //public IWebElement editRecordCardFilemanger;

        public IWebElement EditRecordCardFilemanger => Driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_AskodGridCards_CommonGrid_ctl00__0 > td:nth-child(2) > input[type=image]"));
        public IWebElement CardTitle => Driver.FindElement(By.CssSelector("table tbody td:nth-child(2) > em > div"));
        

        public OpenCardComponent(IWebDriver driver) : base(driver)
        {
        }

        public void OpenIncomingCard()
        {
            EditRecordCardFilemanger.Click();
        }
    }
}
