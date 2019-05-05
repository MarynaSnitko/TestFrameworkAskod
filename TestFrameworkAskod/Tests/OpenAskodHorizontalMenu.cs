using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;
using TestFrameworkAskod.Pages;

namespace TestFrameworkAskod.Tests
{
    public class OpenAskodHorizontalMenu : TestAbstract
    {
        [Test]
        public void OpeningTeamworkMenuTest()
        {
            string expectedVerticalMenuElement = "Мої документи";

            AuthorizationAskodPage authorizationAskodPage = new AuthorizationAskodPage(driver);
            authorizationAskodPage.Login(authorizationAskodPage.validLogin, authorizationAskodPage.validPassword);

            AskodHorizontalMenuComponent askodHorizontalMenu = new AskodHorizontalMenuComponent(driver);
            askodHorizontalMenu.ClickHorizontalMenuItem(askodHorizontalMenu.menuTeamwork);
            Thread.Sleep(1000);
            IList<IWebElement> verticalMenuElements = driver.FindElements(By.CssSelector("span.rtIn"));

            bool isMyDocumentMenuFound = false;
            foreach (var element in verticalMenuElements)
            {
                if (element.Text == expectedVerticalMenuElement)
                {
                    isMyDocumentMenuFound = true;
                    break;
                }
            }
            Assert.True(isMyDocumentMenuFound, $"Element {expectedVerticalMenuElement} is not found");

        }

    }
}
