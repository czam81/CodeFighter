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
            player2 = new CodeFighterPlayer("Pepe", "Dev");
        }

        [TestMethod]        
        public void UseSpecialWhenPlayerEnergyEquals100()
        {
            player1.energy = 0;         
            var game = new CodeFighterGame(player1, player2);

            game.round.player1.energy = 100;
            game.round.player1.special();

            Assert.AreEqual(15, game.round.player1.energy);
        }
    }
}
