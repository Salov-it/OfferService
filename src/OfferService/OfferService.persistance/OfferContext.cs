using Microsoft.EntityFrameworkCore;
using OfferService.Domain;
using OfferService.Application.Interface;
namespace OfferService.persistance
{
    public class OfferContext : DbContext, IOfferContext
    {
        public DbSet<Offer>offers { get; set; }

        public OfferContext(DbContextOptions<OfferContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Config());
            base.OnModelCreating(modelBuilder);
        }
    }
}
