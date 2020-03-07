using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace LightYear.Models
{
    public class LightYearDebugger
    {
        [Key]
        public int LightYearDebuggerId {get;set;}
        //
        public List<Ship> Armada {get;set;}
        // 
        public List<Player> Players {get;set;}
        // 
        public List<Ship> P1_Ships_Targeted {get;set;}
        // 
        public List<Ship> P2_Ships_Targeted {get;set;}
        // 
        public List<Ship> P1_Ships_Killed_In_Turn {get;set;}
        // 
        public List<Ship> P2_Ships_Killed_In_Turn {get;set;}
        // 
        public int P1_Pop_lost_In_Turn {get;set;}
        // 
        public int P2_Pop_lost_In_Turn {get;set;}
        // 
        public int P1_Total_Ship_Kills {get;set;}
        // 
        public int P2_Total_Ship_Kills {get;set;}
        // 
        public int P1_Total_Pop_Lost {get;set;}
        // 
        public int P2_Total_Pop_Lost {get;set;}
        // 
        public int Total_Ships_Lost {get;set;}
        // 
        public int Total_Pop_Lost {get;set;}
        // 
        public DateTime CreatedAt {get;set;}
        //
        public DateTime UpdatedAt {get;set;}
        //
    }
}