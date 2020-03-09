using MambaMentalityAPI.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MambaMentalityAPI.Models
{
    public class QuoteDBContext : DbContext
    {
        public QuoteDBContext()
        {

        }

        public QuoteDBContext(DbContextOptions<QuoteDBContext> options) : base(options)
        {

        }

        public QuoteDBContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MambaMentality_Dev;Trusted_Connection=True;MultipleActiveResultSets=True");
        }

    }
}
