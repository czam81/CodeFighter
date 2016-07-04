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
    public class CodeFighterGameTest
    {
        CodeFighterPlayer player1; 
        CodeFighterPlayer player2;

        [TestInitialize]    
        public void Setup()
        {
            player1 = new CodeFighterPlayer("Juan", "QA");
            player2 = new CodeFighterPlayer("Pepe", "DEV");
        }

        [TestMethod]
        public void UseSpecialWhenPlayer1EnergyEquals100()
        {
            player2.energy = 0;
            var game = new CodeFighterGame(player1, player2);

            game.round.player1.kick();
            game.round.player2.receiveKick();
            game.round.player1.kick();
            game.round.player2.receiveKick();
            game.round.player1.kick();
            game.round.player2.receiveKick();
            game.round.player1.kick();
            game.round.player2.receiveKick();
            game.round.player1.kick();
            game.round.player1.kick();
            game.round.player1.kick();
            game.round.player1.special();

            Assert.AreEqual(30, game.round.player1.energy);
        }

        [TestMethod]
        public void UseSpecialWhenPlayer2Kick7TimesAndPlayerOneReceive1Kick()
        {
            var game = new CodeFighterGame(player1, player2);

            game.round.player2.kick();
            game.round.player1.receiveKick(); 
            game.round.player2.kick();
            game.round.player2.kick();
            game.round.player2.kick();
            game.round.player2.kick();
            game.round.player2.kick();
            game.round.player2.kick();
            game.round.player2.special();

            Assert.AreEqual(30, game.round.player2.energy);
        }

        [TestMethod]
        public void UseSpecialWhenPlayer1Begin()
        {
            player1.energy = 0;
            var game = new CodeFighterGame(player1, player2);

            game.round.player1.special();

            Assert.AreEqual(0, game.round.player1.energy);
        }

        [TestMethod]
        public void UseSpecialWhenPlayer1EnergyLess100()
        {
            player1.energy = 0;
            var game = new CodeFighterGame(player1, player2);

            game.round.player1.kick();
            game.round.player2.receiveKick();
            game.round.player1.special();

            Assert.AreEqual(16, game.round.player1.energy);
        }


    }
}
