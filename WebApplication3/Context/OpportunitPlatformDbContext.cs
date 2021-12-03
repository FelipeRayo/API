using Microsoft.EntityFrameworkCore;
using System;
using WebApplication3.Models;

namespace WebApplication3.Context
{
    public class OpportunitPlatformDbContext : DbContext
    {
        public OpportunitPlatformDbContext()
        {

        }

        public OpportunitPlatformDbContext(DbContextOptions<OpportunitPlatformDbContext> options) 
            : base(options)
        {

        }

        public virtual DbSet<Users> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=OpportunitPlatform");
            }
        }
    }
}
