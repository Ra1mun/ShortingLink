namespace ShortingLinks;

public interface ILinkRepository
{
    Task CreateShortLink(Guid linkId, Guid shortLinkId, Uri siteUri, string apiKey);

    Task<Link[]> GetAllLinks();

    Task<Link?> GetLinkByKey(string key);
}