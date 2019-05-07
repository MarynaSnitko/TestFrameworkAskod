using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using System.Threading;
using TestFrameworkAskod.Pages;

namespace TestFrameworkAskod.Tests
{
    public class EditCard : BaseTest
    {
        [Test]
        public void EditingIncomingCurrentCardFilemanagerTest()
        {
            AuthorizationAskodPage authorizationAskodPage = new AuthorizationAskodPage(driver);
            OpenCardindexComponent openCardindexComponent = new OpenCardindexComponent(driver);
            OpenCardComponent openCardComponent = new OpenCardComponent(driver);
            EditCardComponent editingIncomingCurrentCardFilemanagerPage = new EditCardComponent(driver);

            authorizationAskodPage.Login(authorizationAskodPage.validLogin, authorizationAskodPage.validPassword);
            openCardindexComponent.OpenCardindexList();
            openCardComponent.OpenIncomingCard();

            driver.SwitchTo().Frame(0);

            editingIncomingCurrentCardFilemanagerPage.ContentField.SendKeys("Test");
            editingIncomingCurrentCardFilemanagerPage.CorespondentOpeningDirectory.Click();
            

            Thread.Sleep(27000);
        }
    }
}
