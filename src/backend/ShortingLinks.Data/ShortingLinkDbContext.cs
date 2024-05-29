using Microsoft.EntityFrameworkCore;
using ShortingLinks.Data.Configuration;

namespace ShortingLinks.Data;

public sealed class ShortingLinkDbContext : DbContext
{
    public ShortingLinkDbContext(DbContextOptions<ShortingLinkDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Link>? Links { get; set; }

    public DbSet<ShortLink>? ShortLinks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new LinkConfiguration());
        modelBuilder.ApplyConfiguration(new ShortLinkConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}


