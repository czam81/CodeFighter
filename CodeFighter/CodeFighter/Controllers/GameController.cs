using CodeFighter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFighter.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            var player1Name = "Luis";
            var player2Name = "Juan";
            CodeFighterPlayer player1 = new CodeFighterPlayer(player1Name, "QA");
            CodeFighterPlayer player2 = new CodeFighterPlayer(player2Name, "DBA");
            CodeFighterGame game = new CodeFighterGame(player1, player2);
            ViewBag.Player1Name = player1Name;
            ViewBag.Player2Name = player2Name;
            ViewBag.Player1CurrentLife = player1.life;
            ViewBag.Player2CurrentLife = player2.life;
            ViewBag.Player1CurrentEnergy = player1.energy;
            ViewBag.Player2CurrentEnergy = player2.energy;
            ViewBag.MaxLife = game.maxLifes;
            ViewBag.MaxEnergy = game.maxEnergy;
            return View();
        }

        [HttpPost]
        public ActionResult ExecSpecialPlayer1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExecSpecialPlayer2()
        {
            return View();
        }
    }

   
}