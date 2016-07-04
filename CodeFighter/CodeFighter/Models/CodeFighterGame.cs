using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFighter.Models
{
    public class CodeFighterGame
    {
        public CodeFighterGame(CodeFighterPlayer player1, CodeFighterPlayer player2)
        {
            rounds = new List<CodeFighterRound>();
            round = 1;
        }

        CodeFighterPlayer player1;
        CodeFighterPlayer player2;
        List<CodeFighterRound> rounds;
        int round;
        int maxLifes = 200;
        int maxEnergy = 100;

        public string geGameWinner()
        {
            return "";
        }
    }
}