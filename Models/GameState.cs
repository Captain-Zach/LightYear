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

        public int p1Population {get;set;}

        public int p2Population {get;set;}
        //
        // public bool isActive {get;set;}
        public int p1Damage {get;set;}
        // 
        public int p2Damage {get;set;}
        // 
        //p2pop
        //p1kills
        //p2kills
    }
}