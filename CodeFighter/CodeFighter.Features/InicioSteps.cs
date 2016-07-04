using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace CodeFighter.Features
{
    [Binding]
    public sealed class InicioSteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        static IWebDriver driver;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            //driver = new ChromeDriver(@"C:\Users\Itachi\Source\Repos\CodeFighter\CodeFighter\packages\WebDriver.ChromeDriver.26.14.313457.1\tools");
            driver = new FirefoxDriver();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Quit();
        }

        [Given(@"I enter the gamex")]
        public void GivenIEnterTheGamex()
        {
            driver.Url = "http://localhost:6961/Home/Index";
        }

        [Given(@"Player(.*) name is set ""(.*)""")]
        public void GivenPlayerNameIsSet(int p0, string p1)
        {
            driver.FindElement(By.Id("txtPlayer" + p0 + "Name")).SendKeys(p1);
        }

        [Given(@"Player(.*) role is set ""(.*)""")]
        public void GivenPlayerRoleIsSet(int p0, string p1)
        {
            driver.FindElement(By.Id("txtPlayer" + p0 + "Role")).SendKeys(p1);
        }

        [Given(@"Start game")]
        public void GivenStartGame()
        {
            driver.FindElement(By.Id("btnStartGame")).Click();
        }

        [Then(@"Life Player(.*) is ""(.*)""")]
        public void ThenLifePlayerIs(int p0, int p1)
        {
            Thread.Sleep(200);
            var currentLife = driver.FindElement(By.Id("lblPlayer" + p0 + "CurrentLife")).Text;
            Assert.AreEqual("200", currentLife);
        }

        [Then(@"Energy Player(.*) is ""(.*)""")]
        public void ThenEnergyPlayerIs(int p0, int p1)
        {
            Thread.Sleep(200);
            var currentEnergy = driver.FindElement(By.Id("lblPlayer" + p0 + "CurrentEnergy")).Text;
            Assert.AreEqual("0", currentEnergy);
        }


    }
}
