using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class MrOneSteps
    {
        [Given(@"I have opened a browser")]
        public void GivenIHaveOpenedABrowser()
        {
            var driver = new ChromeDriver();
            Assert.IsTrue(driver != null);
            ScenarioContext.Current.Add("Driver",  driver);
        }
        
        [Given(@"I have navigated to ""(.*)""")]
        public void GivenIHaveNavigatedTo(string p0)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("Driver");
            driver.Navigate().GoToUrl(p0);
        }
        
        [Given(@"I have entered my username as ""(.*)""")]
        public void GivenIHaveEnteredMyUsernameAs(string p0)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("Driver");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("txtUsername")));
            driver.FindElement(By.Id("txtUsername")).SendKeys(p0);
        }
        
        [Given(@"I have entered my password as ""(.*)""")]
        public void GivenIHaveEnteredMyPasswordAs(string p0)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("Driver");
            driver.FindElement(By.Id("txtPassword")).SendKeys(p0);
        }
        
        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("Driver");
            driver.FindElement(By.Id("btnLogin")).Click();
        }
        
        [Then(@"I should be on the Select Organisation Page")]
        public void ThenIShouldBeOnTheSelectOrganisationPage()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("Driver");
            Assert.IsTrue(driver.Title.Contains("Select configuration and profile"));
            driver.Quit();
            driver.Dispose();
        }
    }
}
