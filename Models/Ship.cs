using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace LightYear.Models
{
    public class Ship
    {
        [Key]
        public int ShipId {get;set;}
        //added GameID
        public int GameId {get;set;}
        // 
        public int PlayerState {get;set;}
        //
        // public Player Owner {get;set;}
        //
        // public string Type {get;set;}
        //
        // public int Timer {get;set;}
        //
        public int Health {get;set;}
        //
        public int Damage {get;set;}
        //
        // public DateTime CreatedAt {get;set;}
        // //
        // public DateTime UpdatedAt {get;set;}
        // // 
    }
}