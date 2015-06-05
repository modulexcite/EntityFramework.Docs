﻿using Microsoft.Data.Entity;

namespace EFModelling.Configuring.FluentAPI.Samples.IndexComposite
{
    class MyContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Index(p => new { p.FirstName, p.LastName });
        }
    }

    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
