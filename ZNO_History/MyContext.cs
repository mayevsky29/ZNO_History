using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZNO_History
{
   public class MyContext : DbContext
    {
        DbSet<Answer> Answers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=95.214.10.36;Port=5432;Database=mayevskydb;Username=maey;Password=$544$B77w**G)K$t!Ube22}mav");
        }
    }
}
