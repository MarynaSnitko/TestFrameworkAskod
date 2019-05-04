using NUnit.Framework;
using System.Threading;
using TestFrameworkAskod.Pages;

namespace TestFrameworkAskod.Tests
{
    public class OpenCardindex : TestAbstract
    {
        [Test]
        public void OpeningCardindexInboxCurrentTest()
        {
            Login(validLogin, validPassword);
            OpeningFilemanagerIncomingCurrent();

            OpenCardindexComponent openingCardindexInboxCurrentPage = new OpenCardindexComponent(driver);
            Assert.True(IsElementPresent(openingCardindexInboxCurrentPage.BredCrumbsFilemanagerIncomingCurrent),
                $"Element '{openingCardindexInboxCurrentPage.BredCrumbsFilemanagerIncomingCurrent}' is not present on the page as expected");

            Thread.Sleep(7000);
        }
    }
}
