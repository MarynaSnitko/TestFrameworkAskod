using NUnit.Framework;
using System.Threading;
using TestFrameworkAskod.Pages;

namespace TestFrameworkAskod.Tests
{
    public class OpenCardindex : BaseTest
    {
        [Test]
        public void OpeningCardindexInboxCurrentTest()
        {
            AuthorizationAskodPage authorizationAskodPage = new AuthorizationAskodPage(driver);
            OpenCardindexComponent openCardindexComponent = new OpenCardindexComponent(driver);

            authorizationAskodPage.Login(authorizationAskodPage.validLogin, authorizationAskodPage.validPassword);
            openCardindexComponent.OpenCardindexList();

            Assert.True(IsElementPresent(openCardindexComponent.BredCrumbsFilemanagerIncomingCurrent),
                $"Element '{openCardindexComponent.BredCrumbsFilemanagerIncomingCurrent}' is not present on the page as expected");

            Thread.Sleep(7000);
        }
    }
}
