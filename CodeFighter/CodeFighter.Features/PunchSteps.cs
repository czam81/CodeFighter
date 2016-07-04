using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CodeFighter.Features
{
    [Binding]
    public sealed class PunchSteps
    {
        static IWebDriver driver;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            driver = new FirefoxDriver();
            //driver = new ChromeDriver(@"H:\Scrum\tenniskata\packages\WebDriver.ChromeDriver.26.14.313457.1\tools");
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
        }

        [Given(@"Player1 ""(.*)"" role1 ""(.*)"" Player2 ""(.*)"" role2 ""(.*)"" start game")]
        public void GivenPlayerRolePlayerRoleStartGame(string name1, string role1, string name2, string role2)
        {
            driver.Url = "http://localhost:6961/";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement txtPlayer1Name = wait.Until<IWebElement>(d => d.FindElement(By.Id("txtPlayer1Name")));
            txtPlayer1Name.SendKeys(name1);
            IWebElement txtPlayer1Role = wait.Until<IWebElement>(d => d.FindElement(By.Id("txtPlayer1Role")));
            txtPlayer1Role.SendKeys(role1);
            IWebElement txtPlayer2Name = wait.Until<IWebElement>(d => d.FindElement(By.Id("txtPlayer2Name")));
            txtPlayer2Name.SendKeys(name2);
            IWebElement txtPlayer2Role = wait.Until<IWebElement>(d => d.FindElement(By.Id("txtPlayer2Role")));
            txtPlayer2Role.SendKeys(role2);
            IWebElement btnStartGame = wait.Until<IWebElement>(d => d.FindElement(By.Id("btnStartGame")));
            btnStartGame.Click();
        }

        [When(@"Player1 Punches")]
        public void WhenPlayerPunches()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement btnPlayer1Punch = wait.Until<IWebElement>(d => d.FindElement(By.Id("btnPlayer1Punch")));
            btnPlayer1Punch.Click();
        }

        [Then(@"Player1 energy is ""(.*)""")]
        public void ThenPlayer1EnergyIs(int currentEnergy)
        {            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement lblPlayer1CurrentEnergy = wait.Until<IWebElement>(d => d.FindElement(By.Id("lblPlayer1CurrentEnergy")));
            Assert.AreEqual(currentEnergy.ToString(), lblPlayer1CurrentEnergy.Text);
        }

        [Then(@"Player2 Life is ""(.*)""")]
        public void ThenPlayer2LifeIs(int currentLife)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement lblPlayer2CurrentLife = wait.Until<IWebElement>(d => d.FindElement(By.Id("lblPlayer2CurrentLife")));
            Assert.AreEqual(currentLife.ToString(), lblPlayer2CurrentLife.Text);
        }

        [When(@"Player2 kicks")]
        public void WhenPlayerKicks()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement btnPlayer2Kick = wait.Until<IWebElement>(d => d.FindElement(By.Id("btnPlayer2Kick")));
            btnPlayer2Kick.Click();
        }

        [Then(@"Player2 energy is ""(.*)""")]
        public void ThenPlayerEnergyIs(int currentEnergy)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement lblPlayer2CurrentEnergy = wait.Until<IWebElement>(d => d.FindElement(By.Id("lblPlayer2CurrentEnergy")));
            Assert.AreEqual(currentEnergy.ToString(), lblPlayer2CurrentEnergy.Text);
        }

        [Then(@"Player1 Life is ""(.*)""")]
        public void ThenPlayerLifeIs(int currentLife)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement lblPlayer1CurrentLife = wait.Until<IWebElement>(d => d.FindElement(By.Id("lblPlayer1CurrentLife")));
            Assert.AreEqual(currentLife.ToString(), lblPlayer1CurrentLife.Text);
        }



        [TestCleanup]
        public void TestClean()
        {
            //Clean
            driver.Quit();
        }
    }
}
