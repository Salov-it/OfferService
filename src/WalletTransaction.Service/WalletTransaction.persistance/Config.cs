using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OfferService.Domain;

namespace OfferService.persistance
{
    internal class Config : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasIndex(w => w.id).IsUnique();
            builder.HasKey(w => w.id);

        }
    }
}
