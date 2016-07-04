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
        public void playerReceives3Punches()
        {
            player.resetLifeForRound();
            player.receivePunch();
            player.receivePunch();
            player.receivePunch();
            var life = player.life;
            Assert.AreEqual(170, life);
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
        public void playerReceives4Kicks()
        {
            player.resetLifeForRound();
            player.receiveKick();
            player.receiveKick();
            player.receiveKick();
            player.receiveKick();
            var life = player.life;
            Assert.AreEqual(120, life);
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
        public void playerReceivesRandomHitsAndDies()
        {
            player.resetLifeForRound();
            player.receiveSpecial();
            player.receiveSpecial();
            player.receiveSpecial();
            player.receivePunch();
            player.receivePunch();
            player.receivePunch();
            player.receiveKick();
            player.receiveKick();
            player.receiveKick();
            player.receiveKick();
            player.receiveKick();
            var life = player.life;
            Assert.AreEqual(0, life);
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

        [TestMethod]
        public void playerPunches()
        {
            player.resetLifeForRound();
            player.punch();
            var energy = player.energy;
            Assert.AreEqual(5, energy);
        }
        [TestMethod]
        public void playerKicks()
        {
            player.resetLifeForRound();
            player.kick();
            var energy = player.energy;
            Assert.AreEqual(8, energy);
        }
        [TestMethod]
        public void playerDoSpecialWithoutEnoughEnergy()
        {
            player.resetLifeForRound();
            player.energy = 50;
            player.special();
            var energy = player.energy;
            Assert.AreEqual(50, energy);
        }

        [TestMethod]
        public void playerDoSpecial()
        {
            player.resetLifeForRound();
            player.energy = 100;
            player.special();
            var energy = player.energy;
            Assert.AreEqual(15, energy);
        }

        [TestMethod]
        public void playerCappedEnergy()
        {
            player.resetLifeForRound();
            player.energy = 100;
            player.punch();
            var energy = player.energy;
            Assert.AreEqual(100, energy);
        }

    }
}
