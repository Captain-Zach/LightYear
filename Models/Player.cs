using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace LightYear.Models
{
    public class Player
    {
        [Key]
        public int PlayerId {get;set;}
        //
        public string Name {get;set;}
        //
        public int PlayerState {get;set;}
        //
        public  bool IsActive {get;set;}
        //
        public DateTime CreatedAt {get;set;}
        //
        public DateTime UpdatedAt {get;set;}
        //
        public List<Ship> Armada {get;set;}
    }
}