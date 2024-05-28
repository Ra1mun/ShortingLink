namespace ShortingLinks;

public interface TLink
{
    Guid Id { get; set; }
    Uri SiteURI { get; set; }
}