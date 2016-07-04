using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFighter.Models
{
    public class CodeFighterGame
    {
        public CodeFighterRound round;

        public CodeFighterGame(CodeFighterPlayer player1, CodeFighterPlayer player2)
        {
            rounds = new List<CodeFighterRound>();
            this.player1 = player1;
            this.player2 = player2;
            roundNumber = 1;
            round = new CodeFighterRound(player1,player2);
        }

        CodeFighterPlayer player1;
        CodeFighterPlayer player2;
        List<CodeFighterRound> rounds;
        int roundNumber;
        int maxLifes = 200;
        int maxEnergy = 100;

        public string geGameWinner()
        {
            return "";
        }
    }
}