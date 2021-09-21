using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodHands.Domain.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoodHands.Infra.Data.Data
{
    public class GoodHandsSocialWebContext : IdentityDbContext<User>
    {
        public DbSet<GiverProfile> Profiles { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Exchange> Exchanges { get; set; }

        public DbSet<Donation> Donations { get; set; }


        public GoodHandsSocialWebContext(DbContextOptions<GoodHandsSocialWebContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
