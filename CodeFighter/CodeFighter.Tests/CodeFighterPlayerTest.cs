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
        [TestMethod]
        public void UsarEspecialCuandoLaEnergiaDelJugadorUnoEsIgualACienYLaVidaDelOponentemMayorATreinta()
        {
            var player1 = new CodeFighterPlayer("Juan","QA");
            var player2 = new CodeFighterPlayer("Pepe", "Dev");
            var game = new CodeFighterGame(player1,player2);

            game.round.player1.special();
           
            Assert.AreEqual("170",game.round.player2.life);
        }
    }
}
