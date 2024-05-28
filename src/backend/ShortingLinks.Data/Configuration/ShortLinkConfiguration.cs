using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShortingLinks.Data.Configuration
{
    public class ShortLinkConfiguration : IEntityTypeConfiguration<ShortLink>
    {
        public void Configure(EntityTypeBuilder<ShortLink> builder)
        {
            builder.HasKey(sl => sl.Id);

            builder
                .HasOne(sl => sl.Link)
                .WithOne(l => l.ShortLink)
                .HasForeignKey<ShortLink>(sl => sl.LinkId);
        }
    }
}
