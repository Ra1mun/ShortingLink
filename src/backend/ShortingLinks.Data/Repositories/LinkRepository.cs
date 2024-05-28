using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShortingLinks.Data.Repositories
{
    public class LinkRepository : ILinkRepository
    {
        private readonly ShortingLinkDbContext _context;

        public LinkRepository(ShortingLinkDbContext context)
        {
            _context = context;
        }
        
        public async Task<Link[]> GetAllLinks()
        {
            return await _context.Links
                .AsNoTracking()
                .Include(l => l.ShortLink)
                .ToArrayAsync();
        }

        public async Task CreateShortLink(Guid linkId, Guid shortLinkId, Uri siteUri, string apiKey)
        {
            var link = new Link()
            {
                Id = linkId,
                SiteURI = siteUri,
                ShortLinkId = shortLinkId,
            };

            var shortLink = new ShortLink()
            {
                Id = shortLinkId,
                Key = apiKey,
                LinkId = linkId,
            };

            await _context.AddAsync(link);
            await _context.AddAsync(shortLink);
            await _context.SaveChangesAsync();
        }

        public async Task<Link?> GetLinkByKey(string key)
        {
            return await _context.Links
                .FirstOrDefaultAsync(l => l.ShortLink.Key == key);
        }
    }
}

