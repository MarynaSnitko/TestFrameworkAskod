using NUnit.Framework;
using System.Threading;
using TestFrameworkAskod.Pages;

namespace TestFrameworkAskod.Tests
{
    public class AttachFileTemplate : TestAbstract
    {
        [Test]
        public void AttachFileTemplateTest()
        {
            Login(validLogin, validPassword);
            OpeningFilemanagerIncomingCurrent();
            OpeningIncomingCard();

            

            Thread.Sleep(7000);
        }
    }
}
