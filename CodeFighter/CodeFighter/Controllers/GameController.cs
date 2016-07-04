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

            Session["Game"] = game;
            return View();
        }

        [HttpPost]
        public JsonResult Player1Punch()
        {
            CodeFighterGame game = (CodeFighterGame)Session["Game"];
            game.player1.punch();
            game.player2.receivePunch();
            Session["Game"] = game;
            return Json(new
            {
                Player1CurrentEnergy = game.player1.energy,
                Player2CurrentLife = game.player2.life
            });
        }

        [HttpPost]
        public JsonResult Player2Punch()
        {
            CodeFighterGame game = (CodeFighterGame)Session["Game"];
            game.player2.punch();
            game.player1.receivePunch();
            Session["Game"] = game;
            return Json(new
            {
                Player2CurrentEnergy = game.player2.energy,
                Player1CurrentLife = game.player1.life
            });
        }

        [HttpPost]
        public JsonResult Player1Kick()
        {
            CodeFighterGame game = (CodeFighterGame)Session["Game"];
            game.player1.kick();
            game.player2.receiveKick();
            Session["Game"] = game;
            return Json(new
            {
                Player1CurrentEnergy = game.player1.energy,
                Player2CurrentLife = game.player2.life
            });
        }

        [HttpPost]
        public JsonResult Player2Kick()
        {
            CodeFighterGame game = (CodeFighterGame)Session["Game"];
            game.player2.kick();
            game.player1.receiveKick();
            Session["Game"] = game;
            return Json(new
            {
                Player2CurrentEnergy = game.player2.energy,
                Player1CurrentLife = game.player1.life
            });
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