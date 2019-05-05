using NUnit.Framework;
using System.Threading;
using TestFrameworkAskod.Pages;

namespace TestFrameworkAskod.Tests
{
    public class GenerateReport : TestAbstract
    {
        [Test]
        public void GenerateReportTest()
        {
            string expectedTextMessage = "Звіт сформований, завантажити?";

            AuthorizationAskodPage authorizationAskodPage = new AuthorizationAskodPage(driver);
            OpenCardindexComponent openCardindexComponent = new OpenCardindexComponent(driver);
            ToolbarCardindexComponent toolbarCardindexComponent = new ToolbarCardindexComponent(driver);

            authorizationAskodPage.Login(authorizationAskodPage.validLogin, authorizationAskodPage.validPassword);
            openCardindexComponent.OpenCardindexList();

            Thread.Sleep(17000);
            toolbarCardindexComponent.GenerateReport();

            string actualTextMessage = toolbarCardindexComponent.TextMessageSuccessGenerateReport.Text.Trim();

            Assert.AreEqual(expectedTextMessage, actualTextMessage, $"An expected message is {expectedTextMessage}, but actual message is {actualTextMessage}");

            Thread.Sleep(17000);
        }
    }
}
