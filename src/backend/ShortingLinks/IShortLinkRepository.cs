using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortingLinks
{
    public interface IShortLinkRepository
    {
        Task<ShortLink?> GetShortLinkByKey(string shortLinkKey);
    }
}
