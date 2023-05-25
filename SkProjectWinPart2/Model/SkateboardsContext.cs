using Microsoft.EntityFrameworkCore;
using Model.Data;
using System;

namespace Model
{
    public class SkateboardsContext : DbContext
    {

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Wheel> Wheels { get; set; }
        public DbSet<Bearing> Bearings { get; set; }
        public DbSet<Skateboard> Skateboards { get; set; }

        public SkateboardsContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SkateBoardsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
