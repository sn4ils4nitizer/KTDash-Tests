using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasePage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KTDashPageObject
{

    public class KTDashPO
    {
        //Page Elements For Log In 
        public By unername = By.Id("username");
        public By password = By.Id("password");
        public By loginBtn = By.XPath("//*[@id='navbarNav']/ul/li[3]/a");
        public By loginBtn2 = By.XPath("/html/body/div[2]/form/button");

        //Page Elements After Log In
        public By titleWelcome = By.XPath("/html/body/div[20]/h1");
        public By cancelInstallBtn = By.XPath("//*[@id='installmodal']/div/div/div[3]/button[1]");
        public By newRosterDefault = By.XPath("//a[contains(text(), 'new roster')]");

        //New Roster Pop-up
        public By newRosterName = By.Id("newrostername");
        public By factionChaos = By.XPath("//option[contains(text(), 'Chaos')]");
        public By killteamLegionaries = By.XPath("//option[contains(text(), 'Legionaries')]");
        public By createRosterBtn = By.XPath("//button[contains(text(), 'Create Roster')]");

        //Roster Editing
        public By addOperativeDefault = By.XPath("//a[contains(text(), 'add one now')]");
        public By operativesFromList = By.XPath("//@ng-value");

        //Top right menu buttons
        public By settingsBtn = By.XPath("//*[@id='navbarNav']/ul/li[6]/a");
        public By myRostersBtn = By.XPath("//*[@id=\'navbarNav\']/ul/li[5]/a");

        //Page Elements In the Options Menu
        public By randomOpNameOffBtn = By.XPath("/html/body/div[20]/div[1]/div[2]/button[2]");
    }

}
