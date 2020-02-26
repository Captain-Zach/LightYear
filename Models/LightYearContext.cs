using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using LightYear.Models;


namespace LightYear.Models
{
    public class LightYearContext: DbContext
    {
        public LightYearContext(DbContextOptions options) : base(options) { }
        public DbSet<Player> Players {get;set;}
        //
        public DbSet<Ship> Ships {get;set;}
        //
        // public DbSet<BattleLog> BattleLogs {get;set;}
        //
        public DbSet<GameState> Instances {get;set;}

    }
}