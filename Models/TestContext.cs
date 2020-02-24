using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace LightYear.Models
{
    public class LightYearContext: DbContext
    {
        public LightYearContext(DbContextOptions options) : base(options) { }
                //public DbSet<User> Users {get; set;}
        public DbSet<Player> Players {get;set;}
        //
        public DbSet<Ship> Ships {get;set;}
        //
        public DbSet<Fleet> Fleets {get;set;}

    }
}