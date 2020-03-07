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
                return RedirectToAction("EndGame");
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
            // create debugger instance
            LightYearDebugger CombatLog = new LightYearDebugger();
            CombatLog.P1_Total_Ship_Kills = 0;
            CombatLog.P2_Total_Ship_Kills = 0;
            CombatLog.P1_Total_Pop_Lost = 0;
            CombatLog.P2_Total_Pop_Lost = 0;
            CombatLog.Total_Ships_Lost = 0;
            CombatLog.Total_Pop_Lost = 0;
            dbContext.Add(CombatLog);
            HttpContext.Session.SetInt32("CombatLogId", CombatLog.LightYearDebuggerId);
            Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
            Console.WriteLine($"CombatLog ID: {HttpContext.Session.GetInt32("CombatLogId")}");
            Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
            dbContext.SaveChanges();
            return RedirectToAction("Lobby", "Home");
        }

        // [HttpGet("clear")]
        public RedirectToActionResult EndGame()
        {
            // set players to inactive
            // deleting players for now
            // Player playerOne = dbContext.Players.FirstOrDefault(p => p.PlayerState == 1);
            // Player playerTwo = dbContext.Players.FirstOrDefault(p => p.PlayerState == 2);
            // dbContext.Players.Remove(playerOne);
            // dbContext.Players.Remove(playerTwo);
            List<Player> allPlayers = dbContext.Players.ToList();
            foreach(Player x in allPlayers)
                dbContext.Remove(x);
            List<Ship> allShips = dbContext.Ships.ToList();
            foreach(Ship ship in allShips) {dbContext.Remove(ship);}
            dbContext.SaveChanges();
            // big stuff.
            HttpContext.Session.Clear();
            return RedirectToAction("Intro", "Home");
        }
        public IActionResult StartGame()
        {
            return RedirectToAction("GameScreen", "Home");
        }

        public IActionResult TESTERX()
        {
            // put loop here

            //
            return RedirectToAction("Results", "Home");
        }

        public IActionResult MakeShips(int shipNumber)
        {
            // GameState gameState = dbContext.Instances.FirstOrDefault(g => g.GameId == HttpContext.Session.GetInt32("GameId"));
            List<Ship> newShips = new List<Ship>();
            GameState gameState = dbContext.Instances.FirstOrDefault(g => g.GameId == HttpContext.Session.GetInt32("GameId"));
            Player playerState = dbContext.Players.FirstOrDefault(p => p.PlayerState == HttpContext.Session.GetInt32("PlayerState"));
            for(int i = 0; i < shipNumber; i++)
            {
                Ship ship = new Ship(playerState.PlayerState, gameState.GameId);
                newShips.Add(ship);
            }
            foreach(Ship ship in newShips){
                if(playerState.PlayerState == 1)
                {
                    gameState.p1Population -= ship.Cost;
                }
                if(playerState.PlayerState == 2)
                {
                    gameState.p2Population -= ship.Cost;
                }
                dbContext.Add(ship);
            }
            dbContext.SaveChanges();
            return RedirectToAction ("GameScreen", "Home");
        }

        public IActionResult TurnX()
        {
            GameState gameState = dbContext.Instances.FirstOrDefault(g => g.GameId == HttpContext.Session.GetInt32("GameId"));
            if(HttpContext.Session.GetInt32("PlayerState") == 1)
            {
                // Player one turn readyu
                gameState.p1Turn = true;
            }
            if(HttpContext.Session.GetInt32("PlayerState") == 2) 
            {
                // Player two turn readyu
                gameState.p2Turn = true;
            } 
            dbContext.SaveChanges();
            return RedirectToAction("GameScreen", "Home");
        }
        public IActionResult Turn()
        {
            GameState gameState = dbContext.Instances.FirstOrDefault(g => g.GameId == HttpContext.Session.GetInt32("GameId"));

            if(HttpContext.Session.GetInt32("PlayerState")==1)
            {
                Ship ship = new Ship();
                ship.Damage = 5;
                ship.Health = 5;
                ship.GameId = gameState.GameId;
                ship.PlayerState = 1;
                ship.Cost = 5;
                dbContext.Add(ship);
                gameState.p1Population -= ship.Cost;
                dbContext.SaveChanges();
                gameState.p1Turn = true;
            }
            if(HttpContext.Session.GetInt32("PlayerState")==2)
            {
                Ship ship = new Ship();
                ship.Damage = 5;
                ship.Health = 5;
                ship.GameId = gameState.GameId;
                ship.PlayerState = 2;
                ship.Cost = 5;
                dbContext.Add(ship);
                gameState.p2Population -= ship.Cost;
                dbContext.SaveChanges();
                
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
            // Battle1();
            // Battle2();
            Battle();
            // Grow Population
            Grow();
            // GameOver Check
            if(gameState.p1Population < 1 || gameState.p2Population < 1)
            {

                return RedirectToAction("GameOver", "Home");
            }
            // GameOverCheck();

            TurnChange(gameState.GameId);
            return RedirectToAction("GameScreen", "Home");
        }

        public void Battle()
        {
                // 
                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                Console.WriteLine($"Battle Activated");
                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                //
            GameState GS = dbContext.Instances.FirstOrDefault(g => g.GameId == HttpContext.Session.GetInt32("GameId"));
            List<Ship> p1Ships = dbContext.Ships.Where(s => s.PlayerState == 1).ToList();
            List<Ship> p2Ships = dbContext.Ships.Where(s => s.PlayerState == 2).ToList();
            // loop through all ships in player ships
            List<Ship> targeted_ships = new List<Ship>();
            List<int> damages_list = new List<int>();
            Random randy = new Random(); 
            GS.p2Damage = 0;
            foreach(Ship p1Ship in p1Ships)
            {
                // target random enemy ship
                    // 
                    Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                    Console.WriteLine($"Player {p1Ship.PlayerState} Ship: {p1Ship.ShipId} is in combat");
                    Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                    // 
                    if(p2Ships.Count < 1){
                    DamagePlayer2(p1Ship.Damage);
                    GS.p2Damage += p1Ship.Damage;
                }
                if(p2Ships.Count >= 1)
                {
                    Ship ship_currently_targeted = p2Ships[randy.Next(0, p2Ships.Count)];
                    if(dbContext.Ships.FirstOrDefault(s => s.ShipId == ship_currently_targeted.ShipId) != null)
                    {
                            // 
                            Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                            Console.WriteLine($"Player {p1Ship.PlayerState} Ship {p1Ship.ShipId} is targetting {ship_currently_targeted.ShipId}");
                            Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                            //
                        // if accuracy is correct
                        // IN FUTURE, Number is Ship.Accuracy                
                        bool ship_aim = Ship_Accuracy(85);
                        if(ship_aim == true)
                        {
                            // add ship to list ships
                            // add damage taken to list damage
                                // 
                                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                                Console.WriteLine($"Player {p1Ship.PlayerState} Ship {p1Ship.ShipId} Hit = {ship_aim}");
                                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                                //
                            targeted_ships.Add(ship_currently_targeted);
                            damages_list.Add(p1Ship.Damage);
                            
                        }
                        if(ship_aim == false)
                        {
                            DamagePlayer2(p1Ship.Damage);
                            GS.p2Damage += p1Ship.Damage;
                        }
                    }
                }
            }

            
                                // return;
            GS.p1Damage = 0;
            foreach(Ship p2Ship in p2Ships)
            {
                    // 
                    Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                    Console.WriteLine($"Player {p2Ship.PlayerState} Ship {p2Ship.ShipId} is in combat");
                    Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                    //
                if(p1Ships.Count < 1){
                    DamagePlayer1(p2Ship.Damage);
                    GS.p1Damage += p2Ship.Damage;
                }
                if(p1Ships.Count >= 1)
                {
                    Ship ship_currently_targeted = p1Ships[randy.Next(0, p1Ships.Count)];
                    if(dbContext.Ships.FirstOrDefault(s => s.ShipId == ship_currently_targeted.ShipId) != null)
                    {
                            // 
                            Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                            Console.WriteLine($"Player {p2Ship.PlayerState} Ship {p2Ship.ShipId} is targetting {ship_currently_targeted.ShipId}");
                            Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                            //
                        bool ship_aim = Ship_Accuracy(85);
                        if(ship_aim == true)
                        {
                            if(dbContext.Ships.FirstOrDefault(s => s.ShipId == ship_currently_targeted.ShipId) != null)
                            {
                                // 
                                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                                Console.WriteLine($"Player {p2Ship.PlayerState} Ship {p2Ship.ShipId} Hit = {ship_aim}");
                                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                                //
                            targeted_ships.Add(ship_currently_targeted);
                            damages_list.Add(p2Ship.Damage);
                            }
                        }
                        if(ship_aim == false)
                        {
                            DamagePlayer1(p2Ship.Damage);
                            GS.p1Damage += p2Ship.Damage;
                        }
                    }
                }
            }

            Ships_Damaged(targeted_ships,damages_list);

                // 
                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                Console.WriteLine($"Targeting these ships");
                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                //
            foreach(Ship ship in targeted_ships)
            {
                // 
                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                Console.WriteLine($"Ship Target {ship.ShipId}");
                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                //

            }
            Ship_Cleanup();
            
        }


        public void Grow()
        {
            GameState GS = dbContext.Instances.FirstOrDefault(g => g.GameId == HttpContext.Session.GetInt32("GameId"));
            GS.p1Population += 5;
            GS.p2Population += 5;
            dbContext.SaveChanges();
        }

        public void TurnChange(int gameId)
        {
            GameState GS = dbContext.Instances.FirstOrDefault(g => g.GameId == gameId);
            GS.p1Turn = false;
            GS.p2Turn = false;
            GS.turnNumber++;
            dbContext.SaveChanges();
        }

        public void DamagePlayer1(int damage)
        {
            GameState GS = dbContext.Instances.FirstOrDefault(g => g.GameId == HttpContext.Session.GetInt32("GameId"));
            GS.p1Population -= damage;
            dbContext.SaveChanges();
        }

        public void DamagePlayer2(int damage)
        {
            GameState GS = dbContext.Instances.FirstOrDefault(g => g.GameId == HttpContext.Session.GetInt32("GameId"));
            GS.p2Population -= damage;
            dbContext.SaveChanges();
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
        public void Ships_Damaged(List<Ship> damaged_ships, List<int> damage_taken)
        {
                // 
                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                Console.WriteLine($"Ships_Damaged Activated");
                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                // 
            for(var i = 0; i < damaged_ships.Count; i++)
            {
                // pair index value (ship) with index value (damage)
                
                Ship selected_ship = damaged_ships[i];
                    // 
                    Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                    Console.WriteLine($"Ship {selected_ship.ShipId} Health is {selected_ship.Health}");
                    Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                    // 
                int selected_damage = damage_taken[i];
                // subtract damage from ship health
                selected_ship.Health -= selected_damage;
                    // 
                    Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                    Console.WriteLine($"Ship {selected_ship.ShipId} Damaged, Health {selected_ship.Health}");
                    Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                    // 
                // if health 0 or less
            } 

            dbContext.SaveChanges();
        }
        
        public void Ship_Cleanup()
        {
            // int? CombatLogID = HttpContext.Session.GetInt32("CombatLogID");
            LightYearDebugger CombatLog1 = dbContext.LightYearDebug.OrderByDescending(cl => cl.LightYearDebuggerId).FirstOrDefault();
            List<Ship> removeTheseShips = dbContext.Ships.Where(s => s.Health <= 0 ).ToList();
            if(removeTheseShips.Count > 0)
            {   
                foreach(Ship ship in removeTheseShips)
                {
                    if(ship.PlayerState == 1)
                    {
                        CombatLog1.P1_Total_Ship_Kills++;
                    }
                    if(ship.PlayerState == 2)
                    {
                        CombatLog1.P2_Total_Ship_Kills++;
                    }
                }
                foreach(Ship ship in removeTheseShips)
                {
                        // 
                        Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                        Console.WriteLine($"Ship {ship.ShipId} Health is {ship.Health}");
                        Console.WriteLine($"Ship {ship.ShipId} Removed");
                        Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                        // 
                    // if ship in database, remove
                    // else do nothing
                    if(dbContext.Ships.FirstOrDefault(s => s.ShipId == ship.ShipId) != null)
                    {
                        dbContext.Remove(ship);
                    }
                }
                // 
                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                Console.WriteLine($"Player 1: Total ships killed {CombatLog1.P1_Total_Ship_Kills}");
                Console.WriteLine($"Player 2: Total ships killed {CombatLog1.P1_Total_Ship_Kills}");
                Console.WriteLine(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                //
            }
            
        }
        
        public bool Ship_Accuracy(int accurX)
        {
            Random randall = new Random();
            int numberX = randall.Next(0, 101);
            if(numberX > accurX)
            {
                return false;
            }
            return true;
        }

    }
} 