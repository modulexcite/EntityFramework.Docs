﻿using Microsoft.Data.Entity;

namespace EFModelling.Configuring.FluentAPI.Samples.Relational.Column
{
    class MyContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .Property(b => b.BlogId)
                .ForRelational()
                .Column("blog_id");
        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
    }
}
