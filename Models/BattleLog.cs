using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace LightYear.Models
{
    public class BattleLog
    {
        [Key]
        public int BattleLogId {get;set;}
        // 
        public int Turn {get;set;}

        public List<Ship> Player1_Ships {get;set;}

        public List<Ship> Player2_Ships {get;set;}

        public int Player_1_Ships_Destroyed {get;set;}

        public int Player_2_Ships_Destroyed {get;set;}

        public DateTime CreatedAt {get;set;}
        //
        public DateTime UpdatedAt {get;set;}
        // 
    } 
}