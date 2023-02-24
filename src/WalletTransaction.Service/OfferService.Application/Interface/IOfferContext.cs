using Microsoft.EntityFrameworkCore;
using OfferService.Domain;

namespace OfferService.Application.Interface
{
    public interface IOfferContext
    {
        public DbSet<Offer> offers { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
