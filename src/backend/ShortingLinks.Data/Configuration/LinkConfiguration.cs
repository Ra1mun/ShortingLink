using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortingLinks.Data.Configuration
{
    public class LinkConfiguration : IEntityTypeConfiguration<Link>
    {
        public void Configure(EntityTypeBuilder<Link> builder)
        {
            builder.HasKey(l => l.Id);

            builder
                .HasOne(l => l.ShortLink)
                .WithOne(sl => sl.Link)
                .HasForeignKey<Link>(l => l.ShortLinkId);
        }
    }
}
