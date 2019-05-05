using NUnit.Framework;
using System.Threading;
using TestFrameworkAskod.Pages;

namespace TestFrameworkAskod.Tests
{
    public class OpenCard : TestAbstract
    {
        [Test]
        public void OpeningCardindexInboxCurrentTest()
        {
            AuthorizationAskodPage authorizationAskodPage = new AuthorizationAskodPage(driver);
            OpenCardindexComponent openCardindexComponent = new OpenCardindexComponent(driver);
            OpenCardComponent openCardComponent = new OpenCardComponent(driver);

            authorizationAskodPage.Login(authorizationAskodPage.validLogin, authorizationAskodPage.validPassword);
            openCardindexComponent.OpenCardindexList();
            openCardComponent.OpenIncomingCard();

            //OpeningCardindexInboxCurrentPage openingCardindexInboxCurrentPage = new OpeningCardindexInboxCurrentPage(driver);
            //Assert.True(IsElementPresent(openingCardindexInboxCurrentPage.bredCrumbsFilemanagerIncomingCurrent),
            //    $"Element '{openingCardindexInboxCurrentPage.bredCrumbsFilemanagerIncomingCurrent}' is not present on the page as expected");

            Thread.Sleep(7000);
        }
    }
}
