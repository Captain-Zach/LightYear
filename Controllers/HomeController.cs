using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// session
using Microsoft.AspNetCore.Http;
// models
using LightYear.Models;
// .include
using Microsoft.EntityFrameworkCore;


namespace LightYear.Controllers
{
    public class HomeController : Controller
    {
        private LightYearContext dbContext;
        
        public HomeController(LightYearContext context)
        {
            dbContext = context;
        }
        [HttpGet("")]
        public IActionResult Intro()
        {
            return View("Intro");
        }
        public IActionResult Lobby()
        {
            int PlayerId = (int)HttpContext.Session.GetInt32("PlayerState");
            if(PlayerId == 1){
                GameMaker();
            }else if(PlayerId == 2){
                GameJoin();
            }
            Player LoggedPlayer = dbContext.Players.FirstOrDefault(p => p.PlayerState == PlayerId);
            if(dbContext.Players.Where(p => p.IsActive == true).ToList().Count == 2)
            {
                ViewBag.GameReady = true;
                
            }
            else
            {
                ViewBag.GameReady = false;
            }
                return View("Lobby", LoggedPlayer);
        }
        public void GameJoin()
        {
            GameState Game = dbContext.Instances.OrderByDescending(g => g.GameId).FirstOrDefault();
            HttpContext.Session.SetInt32("GameId", Game.GameId);
            System.Console.WriteLine(Game.GameId);
            System.Console.WriteLine("***************************************************************************");
        }
        public void GameMaker()
        {
            if(HttpContext.Session.GetInt32("GameId") != null)
            {
                return;
            }
            GameState newGame = new GameState();
            newGame.p1Turn = false;
            newGame.p2Turn = false;
            newGame.turnNumber = 1;
            // SET PLAYER POPULATIONS
            newGame.p1Population = 100;
            newGame.p2Population = 100;
            dbContext.Add(newGame);
            dbContext.SaveChanges();
            HttpContext.Session.SetInt32("GameId", newGame.GameId);
            System.Console.WriteLine(newGame.GameId);
            System.Console.WriteLine("***************************************************************************");
        }

        public IActionResult GameScreen()
        {
            GameState CurrentState = dbContext.Instances.FirstOrDefault(g => g.GameId == HttpContext.Session.GetInt32("GameId"));

            if(CurrentState.p1Turn == true && CurrentState.p2Turn == true)
            {
                return RedirectToAction("GameLogic", "Post");
            }
            ViewBag.GameState = CurrentState;
            return View("GameScreen");
        }

        public IActionResult GameOver()
        {
            List<Ship> allShips = dbContext.Ships.ToList();
            foreach(Ship ship in allShips) {dbContext.Remove(ship);}
            dbContext.SaveChanges();
            return View();
        }


        public IActionResult Test()
        {   
            if(HttpContext.Session.GetInt32("TurnNumber") == null){
                HttpContext.Session.SetInt32("TurnNumber", 1);
            }
            int turn = (int)HttpContext.Session.GetInt32("TurnNumber");
            turn++;
            HttpContext.Session.SetInt32("TurnNumber", turn);
            return RedirectToAction("Index");
        }

        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        //
        public IActionResult Privacy()
        {
            return View();
        }
        //
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
