using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CodeFighter.Features
{
    [Binding]
    public sealed class NombresSteps
    {
        static IWebDriver driver;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            driver = new ChromeDriver(@"C:\Users\Itachi\Source\Repos\CodeFighter\CodeFighter\packages\WebDriver.ChromeDriver.26.14.313457.1\tools");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Quit();
        }

        [Given(@"I enter the game")]
        public void GivenIEnterTheGame()
        {
            driver.Url = "http://localhost:6961/Home/Index";
        }

        [Given(@"PlayerUno name is set ""(.*)""")]
        public void GivenPlayerUnoNameIsSet(string p0)
        {
            //ScenarioContext.Current.Pending();
            driver.FindElement(By.Id("txtPlayer1Name")).SendKeys(p0);
        }

        [Given(@"PlayerDos name is set ""(.*)""")]
        public void GivenPlayerDosNameIsSet(string p0)
        {
            //ScenarioContext.Current.Pending();
            driver.FindElement(By.Id("txtPlayer2Name")).SendKeys(p0);
        }

        [Then(@"PlayerUno name is get ""(.*)""")]
        public void ThenPlayerUnoNameIsGet(string p0)
        {
            var nombreUno = driver.FindElement(By.Id("txtPlayer1Name")).GetAttribute("value");
            Assert.AreEqual(p0, nombreUno);
        }

        [Then(@"PlayerDos name is get ""(.*)""")]
        public void ThenPlayerDosNameIsGet(string p0)
        {
            var nombreDos = driver.FindElement(By.Id("txtPlayer2Name")).GetAttribute("value");
            Assert.AreEqual(p0, nombreDos);
        }

    }
}
