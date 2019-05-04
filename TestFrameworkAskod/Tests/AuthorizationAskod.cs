using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;
using TestFrameworkAskod.Pages;
using TestFrameworkAskod.Tests;

namespace TestFrameworkAskod
{
    public class AuthorizationAskod : TestAbstract
    {
        [Test]
        public void AuthorizationTestAskod()
        {
            AuthorizationAskodPage authorizationAskodPage = new AuthorizationAskodPage(driver);

            authorizationAskodPage.Login("тест 5", "111"); // Как передать параметры validLogin & validPassword?

            Thread.Sleep(17000);
        }
    }
}
