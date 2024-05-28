using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortingLinks
{
    public class ShortLink
    {
        public Guid Id { get; set; }

        public string Key { get; set; }

        public Guid LinkId { get; set; }

        public Link Link { get; set; }
    }
}
