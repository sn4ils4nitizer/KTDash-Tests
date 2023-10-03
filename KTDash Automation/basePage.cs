using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace BasePage
{
    public class basePage
    {

        public IWebDriver driver = new ChromeDriver();

        public void NavigateTo(string url)
            {
            driver.Navigate().GoToUrl(url);
            }
        public void SetImplicitWait(int seconds)
            {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
            }

        public void WaitForElement(By locator, int seconds)
            {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }

        public void Maximize()
            {
            driver.Manage().Window.Maximize();
            }
        public void Click(By locator)
            {
            driver.FindElement(locator).Click();
            }
        public void CloseBrowser()
            {
            driver.Quit();
            }
        public void SendText(By locator, string text)
            {
            var input = driver.FindElement(locator);
            input.Clear();
            input.SendKeys(text);
            }
        public string GetText(By locator)
        {
            string gottenText = driver.FindElement(locator).Text;
            return gottenText;
        }
    }
}
    
