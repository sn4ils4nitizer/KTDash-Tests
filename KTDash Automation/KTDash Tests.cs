using KTDashPageObject;
using BasePage;

namespace KTDash_Automation
{
    public class Tests
    {

        basePage basePage = new basePage();
        KTDashPO KTPO = new KTDashPO();

        [SetUp]
        public void Setup()
        {
            basePage.NavigateTo("https://ktdash.app/");
            basePage.Maximize();
            basePage.WaitForElement(KTPO.cancelInstallBtn, 10);
            basePage.Click(KTPO.cancelInstallBtn);
            basePage.Click(KTPO.loginBtn);
            basePage.WaitForElement(KTPO.unername, 10);
            basePage.SendText(KTPO.unername, "chaoscultist2");
            basePage.SendText(KTPO.password, "chaoscult2");
            basePage.Click(KTPO.loginBtn2);
        }

        [Test]
        public void Test1()
        {
            basePage.WaitForElement(KTPO.newRosterDefault, 10);
            basePage.Click(KTPO.newRosterDefault);
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}