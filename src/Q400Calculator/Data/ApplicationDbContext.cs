using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Q400Calculator.Models;

namespace Q400Calculator.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ClimbData> ClimbData { get; set; }
        public DbSet<TakeoffFlaps5Above5Below20Data> TakeoffFlaps5Above5Below20Data { get; set; }
        public DbSet<TakeoffFlaps5Above20Data> TakeoffFlaps5Above20 { get; set; }
        public DbSet<TakeoffFlaps10Below20Data> TakeoffFlaps10Below20 { get; set; }

        public DbSet<TakeoffFlaps10Above20> TakeoffFlaps10Above20{ get; set; }

        public DbSet<TakeoffFlaps15Below20Data> TakeoffFlpas15Below20{ get; set; }

        public DbSet<TakeoffFlaps15Above20> TakeoffFlaps15Above20{ get; set; }

        public DbSet<LandingFlaps5> LandingFlaps5 { get; set; }
        public DbSet<LandingFlaps10> LandingFlaps10 { get; set; }
        public DbSet<LandingFlaps15> LandingFlaps15 { get; set; }
        public DbSet<LandingFlaps35> LandingFlaps35 { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<ClimbData>().ToTable("ClimbData");
            builder.Entity<TakeoffFlaps5Above5Below20Data>().ToTable("TakeoffFlaps5Above5Below20Data");
        }



        public DbSet<Inputs> Inputs { get; set; }
    }
}
