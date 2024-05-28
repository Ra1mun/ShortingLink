using Microsoft.AspNetCore.Mvc;

namespace ShortingLinks.Web.Controllers;

[Produces("application/json")]
[Route("")]
[ApiController]
public class ShortLinkController : ControllerBase
{
    private readonly ILinkRepository _linkRepository;

    private const int KeyLength = 10;

    public ShortLinkController(ILinkRepository linkRepository)
    {
        _linkRepository = linkRepository;
    }

    [Route("links")]
    [HttpGet]
    public async Task<Link[]> GetAllLinks()
    {
        return await _linkRepository.GetAllLinks();
    }
    
    [Route("{key}")]
    [HttpGet]
    public async Task<IActionResult> RedirectByKey(string key)
    {
        var link = await _linkRepository.GetLinkByKey(key);

        if (link == null || link.SiteURI == null)
        {
            return BadRequest();
        }

        return Redirect(link.SiteURI.AbsoluteUri);
    }

    [Route("link")]
    [HttpPost]
    public async Task<IActionResult> CreateShortLink(Uri siteUrl)
    {
        var apiKey = TokenGenerator.GenerateRandomKey(KeyLength);

        await _linkRepository.CreateShortLink(Guid.NewGuid(), Guid.NewGuid(), siteUrl, apiKey);

        return Ok(apiKey);
    }
}