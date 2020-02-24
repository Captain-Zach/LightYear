using System.ComponentModel.DataAnnotations;

namespace  LightYear.Models
{
    
    public class Fleet
    {
        [Key]
        public int FleetId {get;set;}
        //
        public int PlayerId {get;set;}
        //
        public Player Player {get;set;}
        //
        public int ShipId {get;set;}
        //
        public Ship Ship {get;set;}
        //
    }
}