using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;
using TestFrameworkAskod.Pages;

namespace TestFrameworkAskod.Tests
{
    public class TestAbstract
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://193.93.185.210:54542/Askod.dev/Default.aspx#");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        public void OpeningFilemanagerIncomingCurrent()
        {
            OpenCardindexComponent openingCardindexInboxCurrentPage = new OpenCardindexComponent(driver);
            //openingCardindexInboxCurrentPage.fileManagerButton.Click();
            openingCardindexInboxCurrentPage.IncomingCardsTreeButton.Click();
            openingCardindexInboxCurrentPage.IncomingCardsCurrentBranch.Click();
        }

        public void OpeningIncomingCard()
        {
            OpenCardComponent openingIncomimgCardFilemanagerPage = new OpenCardComponent(driver);
            openingIncomimgCardFilemanagerPage.EditRecordCardFilemanger.Click();
        }

        public bool IsElementPresent(IWebElement element)
        {
            try
            {
                var result = element.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            throw new Exception("Unexpected exception.");
        }
    }
}
