using CodeFighter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFighter.Tests
{
    [TestClass]
    public class CodeFighterPlayerTest
    {
        CodeFighterPlayer player;
        [TestInitialize]
        public void Setup()
        {
            player = new CodeFighterPlayer("Luis", "DEV");
        }

        [TestMethod]
        public void playerInitialStatus()
        {
            player.resetLifeForRound();
            var life = player.life;
            var energy = player.energy;
            Assert.AreEqual(200, life);
            Assert.AreEqual(0, energy);
        }

        [TestMethod]
        public void playerReceivesPunch()
        {
            player.resetLifeForRound();
            player.receivePunch();
            var life = player.life;
            Assert.AreEqual(190, life);
        }

        [TestMethod]
        public void playerReceivesKick()
        {
            player.resetLifeForRound();
            player.receiveKick();
            var life = player.life;
            Assert.AreEqual(180, life);
        }

        [TestMethod]
        public void playerReceivesSpecial()
        {
            player.resetLifeForRound();
            player.receiveSpecial();
            var life = player.life;
            Assert.AreEqual(170, life);
        }

        [TestMethod]
        public void playerHealsHimself()
        {
            player.resetLifeForRound();
            player.life = 100;
            player.energy = 100;
            player.heal();
            var life = player.life;
            var energy = player.energy;
            Assert.AreEqual(150, life);
            Assert.AreEqual(0, energy);
        }

    }
}
