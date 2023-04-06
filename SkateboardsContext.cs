using Microsoft.EntityFrameworkCore;
using SkateboardsProject.Data.Model;
using SkateboardsProject.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Model
{
    class SkateboardsContext:DbContext
    {
        
        public DbSet<Brand> Brands { get; }
        public DbSet<Deck> Decks { get; }
        public DbSet<Wheel> Wheels { get; }
        public DbSet<Bearing> Bearings { get; }
        public DbSet<Skateboard> Skateboards { get; }

        public SkateboardsContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SkateBoards;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
