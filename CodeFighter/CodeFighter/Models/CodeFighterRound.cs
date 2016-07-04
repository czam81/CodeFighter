using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFighter.Models
{
    public class CodeFighterRound
    {
        public CodeFighterPlayer player1;
        public CodeFighterPlayer player2;

        int player1Life;
        int player1Energy;

        int player2Life;
        int player2Energy;

        public CodeFighterRound(CodeFighterPlayer player1, CodeFighterPlayer player2)
        {
            this.player1 = player1;
            this.player2 = player2;  
        }

        public string getRoundStatus() {
            return "";
        }     
        
           
    }
}