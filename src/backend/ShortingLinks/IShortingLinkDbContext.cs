using Microsoft.EntityFrameworkCore;

namespace ShortingLinks;

public interface IShortingLinkDbContext
{
    DbSet<Link>? Links { get; set; }

    DbSet<ShortLink>? ShortLinks { get; set; }
}