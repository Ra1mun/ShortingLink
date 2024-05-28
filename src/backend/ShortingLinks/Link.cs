namespace ShortingLinks;

public record Link: TLink
{
    public Guid Id { get; set; }

    public Uri? SiteURI { get; set; }

    public Guid ShortLinkId { get; set; }

    public ShortLink ShortLink { get; set; }
}