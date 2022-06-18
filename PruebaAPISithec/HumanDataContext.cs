using Microsoft.EntityFrameworkCore;
using PruebaAPISithec.Models;

namespace PruebaAPISithec
{
    public class HumanDataContext:DbContext
    {
        public HumanDataContext(DbContextOptions<HumanDataContext> options): base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<Humano> Humano { get; set; }
    }
}
