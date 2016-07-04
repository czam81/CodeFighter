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
        [Given(@"Player1 ""(.*)"" role1 ""(.*)"" Player2 ""(.*)"" role2 ""(.*)"" start game")]
        public void GivenPlayerRolePlayerRoleStartGame(int name1, string role1, int name2, string role2)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Player1 Punches")]
        public void WhenPlayerPunches()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Player1 energy is ""(.*)""")]
        public void ThenPlayerEnergyIs(int currentEnergy)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Player1 Life is ""(.*)""")]
        public void ThenPlayerLifeIs(int currentLife)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
