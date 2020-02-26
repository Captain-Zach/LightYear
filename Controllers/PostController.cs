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
    public class PostController : Controller
    {
        private LightYearContext dbContext;

        public PostController(LightYearContext context)
        {
            dbContext = context;
        }
        // Make sure to put in DbContext stuf. I will forget.
        public RedirectToActionResult LoginProcess(string Name)
        {
            // get list of active players
            List<Player> ActivePlayers = dbContext.Players.Where(p => p.IsActive == true).ToList();
            Player newPlayer = new Player();
            //We can't have more than 2 active players
            if(ActivePlayers.Count > 2){
                System.Console.WriteLine("We can't handle this!");
                return RedirectToAction("Intro", "Home");
            }
            // Set player state to player 1 or player 2
            if(ActivePlayers.Count > 0 && ActivePlayers.Count < 2){
                newPlayer.PlayerState = 2;
            }else{
                newPlayer.PlayerState = 1;
            }
            // Build rest of DBEntry
            newPlayer.IsActive = true;
            newPlayer.Name = Name;
            HttpContext.Session.SetInt32("PlayerState", newPlayer.PlayerState);
            newPlayer.CreatedAt = DateTime.Now;
            newPlayer.UpdatedAt = DateTime.Now;
            // newPlayer.PlayerState
            dbContext.Add(newPlayer);
            dbContext.SaveChanges();
            return RedirectToAction("Lobby", "Home");
        }

        [HttpGet("clear")]
        public RedirectToActionResult EndGame()
        {
            // set players to inactive
            // deleting players for now
            Player playerOne = dbContext.Players.FirstOrDefault(p => p.PlayerState == 1);
            Player playerTwo = dbContext.Players.FirstOrDefault(p => p.PlayerState == 2);
            dbContext.Players.Remove(playerOne);
            dbContext.Players.Remove(playerTwo);
            dbContext.SaveChanges();
            // big stuff.
            HttpContext.Session.Clear();
            return RedirectToAction("Intro", "Home");
        }
        public IActionResult StartGame()
        {
            // // HttpContext.Session.SetString("P1Turn", "false");
            // // HttpContext.Session.SetString("P2Turn", "false");
            // // HttpContext.Session.SetInt32("TurnNumber", 1);
            // GameState Gamestate = new GameState();
            // // GameState will handle this 
            // // Gamestate needs reference to player ID's
            // // this will prevent creating multiple game states
            // // per startgame click
            // Gamestate.p1Turn = false;
            // Gamestate.p2Turn = false;
            // Gamestate.turnNumber = 1;
            // dbContext.Add(Gamestate);
            // dbContext.SaveChanges();
            // HttpContext.Session.SetInt32("GameId", Gamestate.GameId);
            // System.Console.WriteLine(Gamestate.GameId);
            // System.Console.WriteLine("*******************************************************************");
            return RedirectToAction("GameScreen", "Home");
        }

        public IActionResult Turn()
        {
            GameState gameState = dbContext.Instances.FirstOrDefault(g => g.GameId == HttpContext.Session.GetInt32("GameId"));
            if(HttpContext.Session.GetInt32("PlayerState")==1)
            {
                gameState.p1Turn = true;
            }
            if(HttpContext.Session.GetInt32("PlayerState")==2)
            {
                gameState.p2Turn = true;
            }
            dbContext.SaveChanges();
            return RedirectToAction("GameScreen", "Home");

        }

        public IActionResult GameLogic()
        {
            // Handle all the logic
            GameState gameState = dbContext.Instances.FirstOrDefault(g => g.GameId == HttpContext.Session.GetInt32("GameId"));
            // Move people
            // Do Battle
            // Grow Population
            TurnChange(gameState.GameId);
            return RedirectToAction("GameScreen", "Home");
        }
        //
        // public IActionResult ProcessNewShip(Ship newship)
        // {   if(("PlayerState") == 1)
        //     {
        //         NewShip.UserId = (int)HttpContext.Session.GetInt32("PlayerState");
        //         dbContext.Add(NewShip);
        //         dbContext.SaveChanges();
        //         return RedirectToAction("PlayerState", NewShip);
        //     }
        //     if(("PlayerState") ==2)
        //     {
                
        //     }
        //     return View("GameScreen");
        // }

        public void TurnChange(int gameId)
        {
            GameState GS = dbContext.Instances.FirstOrDefault(g => g.GameId == gameId);
            GS.p1Turn = false;
            GS.p2Turn = false;
            GS.turnNumber++;
            dbContext.SaveChanges();
        }

        public void DamagePlayer()
        {
            
        }
        // Helper functions Below Here
        // P0 Helper functions

        // create ship player 1
        //      create new ship object
        //      set turns to 3
        //      set does move to true

        // create ship player 2
        //      create new ship object
        //      turns to 0

        // 

        // battle activation
        // public void Battle_Activation()
        // {
        //     foreach(ship in all_ships_Game)
        // }
        //      foreach loop through all ships in one gamestate
        //      new list of ships: ships with same position INT
        //      foreach loop through all ships
        //      set ships Is-Engaged bool to true
        //      split new list into list of ships by each player
        //      

        // are-ships-engaged


        // is-attack-successful
        
        // process attack
        // public void AttackDamage(Ship ShipA, Ship ShipB)
        // {
        //     ShipB.Health -= ShipA.Damage;
        // }

        // calculate when ship is destroyed
        // public void IsShipDestroyed(Ship ShipA)
        // {
        //     if(ShipA.Health <= 0)
        //     {
        //         ShipDestroyed(ShipA);
        //     }
        // }
        // process ship destroyed
        // public void ShipDestroyed(Ship ShipA)
        // {
        //     dbContext.Remove(ShipA);
        //     dbContext.SaveChanges();
        // }
    }
} 