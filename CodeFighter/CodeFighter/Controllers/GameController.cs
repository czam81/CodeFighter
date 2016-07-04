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