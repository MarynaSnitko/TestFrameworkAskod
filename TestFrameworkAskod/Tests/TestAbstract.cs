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

        public string validLogin = "тест 5";
        public string validPassword = "111";

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

        public void Login(string login, string password)
        {
            AuthorizationAskodPage authorizationAskodPage = new AuthorizationAskodPage(driver);

            authorizationAskodPage.LoginField.SendKeys(validLogin);
            authorizationAskodPage.passwordField.SendKeys(validPassword);
            authorizationAskodPage.enterButton.Click();
        }

        public void OpeningFilemanagerIncomingCurrent()
        {
            OpenCardindexComponent openingCardindexInboxCurrentPage = new OpenCardindexComponent(driver);
            //openingCardindexInboxCurrentPage.fileManagerButton.Click();
            openingCardindexInboxCurrentPage.incomingCardsTreeButton.Click();
            openingCardindexInboxCurrentPage.incomingCardsCurrentBranch.Click();
        }

        public void OpeningIncomingCard()
        {
            OpenCardComponent openingIncomimgCardFilemanagerPage = new OpenCardComponent(driver);
            openingIncomimgCardFilemanagerPage.editRecordCardFilemanger.Click();
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
