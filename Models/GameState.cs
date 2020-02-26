using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace LightYear.Models
{
    public class GameState
    {
        [Key]
        public int GameId {get;set;}
        // 
        public bool p1Turn {get;set;}
        // 
        public bool p2Turn {get;set;}
        // 
        public int turnNumber {get;set;}
        //
        public List<Player> All_Players {get;set;}
        // 
        public List<Ship> All_Ships_In_This_Game {get;set;}
        // 
        public List<BattleLog> All_BattleLogs {get;set;}

        public bool isActive {get;set;}


        //p2pop
        //p1kills
        //p2kills
    }
}