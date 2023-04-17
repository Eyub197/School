using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


    public class SkateboardContext:DbContext
    {
        public DbSet<Bearing> Bearings { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Wheel> Wheels { get; set; }
        public DbSet<Skateboard> Skateboards { get; set; }

        public SkateboardContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SkateBoardsss;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connString);
        }
    }
