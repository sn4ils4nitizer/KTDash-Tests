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
            //Set up navigates to KTDash and logs the user into a testing account

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
            //The test will create new kill team list, turn off generating random operative names.
            //Names should default into their role. Run a loop to check that the operative name
            //autofills operative role as the operative name when adding an operative

            basePage.WaitForElement(KTPO.newRosterDefault, 10);
            basePage.Click(KTPO.newRosterDefault);
            //MAKE SCRIPT TO CREATE NEW ROSTER
            basePage.Click(KTPO.settingsBtn);
            basePage.Click(KTPO.randomOpNameOffBtn);
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}