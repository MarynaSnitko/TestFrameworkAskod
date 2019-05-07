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
    public class AuthorizationAskod : BaseTest
    { 
        [Test]
        [Category("Valid authorization")]
        public void AuthorizationTestAskod()
        {
            AuthorizationAskodPage authorizationAskodPage = new AuthorizationAskodPage(driver);

            authorizationAskodPage.Login(authorizationAskodPage.validLogin, authorizationAskodPage.validPassword);

            Assert.True(IsElementPresent(authorizationAskodPage.AskodTodayDataBlock),
                $"Element '{authorizationAskodPage.AskodTodayDataBlock}' is not present on the page as expected");

            Thread.Sleep(17000);
        }

        [Test]
        [Category("Invalid authorization")]
        public void InvalidAuthorizationTestAskod()
        {
            //string expectedText = "Помилка авторизації!Невірно введено логін або пароль користувача.У Вас залишилось 5 спроб(а / и).";

            AuthorizationAskodPage authorizationAskodPage = new AuthorizationAskodPage(driver);

            authorizationAskodPage.InvalidLogin(authorizationAskodPage.invalidLogin, authorizationAskodPage.invalidPassword);

            // TO DO!!!
            //driver.SwitchTo().Frame(0);
            //string actualText = authorizationAskodPage.ErrorMessageInvalidLogin.Text.Trim();

            //Assert.AreEqual(expectedText, actualText, $"An expected message is {expectedText}, but actual message is {actualText}");

            Assert.True(IsElementPresent(authorizationAskodPage.ErrorMessageInvalidLogin),
                $"Element '{authorizationAskodPage.ErrorMessageInvalidLogin}' is not present on the page as expected");

            Thread.Sleep(17000);
        }
    }
}
