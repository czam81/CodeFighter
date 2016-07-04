using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CodeFighter.Features
{
    [Binding]
    public class EspecialSteps
    {
        [Given(@"I enter the play")]
        public void GivenIEnterThePlay()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I add players to game")]
        public void GivenIAddPlayersToGame()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I Click ""(.*)""")]
        public void WhenIClick(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see his ""(.*)"" with ""(.*)""")]
        public void ThenISeeHisWith(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
