using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using System.Threading;
using TestFrameworkAskod.Pages;

namespace TestFrameworkAskod.Tests
{
    public class EditCard : TestAbstract
    {
        [Test]
        public void EditingIncomingCurrentCardFilemanagerTest()
        {
            Login(validLogin, validPassword);
            OpeningFilemanagerIncomingCurrent();
            OpeningIncomingCard();

            EditCardComponent editingIncomingCurrentCardFilemanagerPage = new EditCardComponent(driver);

            driver.SwitchTo().Frame(0);

            editingIncomingCurrentCardFilemanagerPage.contentField.SendKeys("Test");
            editingIncomingCurrentCardFilemanagerPage.corespondentOpeningDirectory.Click();
            

            Thread.Sleep(27000);
        }
    }
}
