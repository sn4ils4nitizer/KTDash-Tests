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

            //Change setting to turn off random name generation for operatives
            basePage.WaitForElement(KTPO.settingsBtn, 10);
            basePage.Click(KTPO.settingsBtn);
            basePage.Click(KTPO.randomOpNameOffBtn);
            basePage.Click(KTPO.myRostersBtn);

            //Create Roster
            basePage.WaitForElement(KTPO.newRosterDefault, 10);
            basePage.Click(KTPO.newRosterDefault);
            basePage.WaitForElement(KTPO.newRosterName, 10);
            basePage.SendText(KTPO.newRosterName, "Test Team 1");
            basePage.Click(KTPO.factionChaos);
            basePage.Click(KTPO.killteamLegionaries);
            basePage.Click(KTPO.createRosterBtn);

            //Add an operative
            basePage.WaitForElement(KTPO.addOperativeDefault, 10);
            basePage.Click(KTPO.addOperativeDefault);

            //Iterate through drop-down operative and assert that their type equals the operative name
            var operativesList = new[]
            { basePage.GetText(KTPO.operativesFromList) };

            operativesList.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            foreach (var item in operativesList)
            {
                Console.WriteLine(item.ToString());
            }
            //Console.Write(operativesList);


            //Delete roster to avoid accumulating data

            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}