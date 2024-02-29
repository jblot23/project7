using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Dot.Net.WebApi.Domain;
using Dot.Net.WebApi.Controllers.Domain;
using System.Data;
using WebApi.Domain;

namespace Dot.Net.WebApi.Data
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext(DbContextOptions<LocalDbContext> options) : base(options)
        {
        }


        public LocalDbContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<BidList> Bids { get; set; }
        public DbSet<CurvePoint> CurvePoints { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<RuleName> Rules { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-3IQ5ASK1;Initial Catalog=PoseidonFinanancialDb;Integrated Security=True");
        }
    }
}