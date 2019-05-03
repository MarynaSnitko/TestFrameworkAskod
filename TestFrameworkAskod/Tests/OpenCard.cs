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
            Login(validLogin, validPassword);
            OpeningFilemanagerIncomingCurrent();
            OpeningIncomingCard();

            //OpeningCardindexInboxCurrentPage openingCardindexInboxCurrentPage = new OpeningCardindexInboxCurrentPage(driver);
            //Assert.True(IsElementPresent(openingCardindexInboxCurrentPage.bredCrumbsFilemanagerIncomingCurrent),
            //    $"Element '{openingCardindexInboxCurrentPage.bredCrumbsFilemanagerIncomingCurrent}' is not present on the page as expected");

            Thread.Sleep(7000);
        }
    }
}
