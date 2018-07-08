using System.Collections.Generic;

namespace WebScraping.Models
{
    public class WordRequirement
    {
        public IEnumerable<string> ForbiddenWords { get; set; }
        public IEnumerable<string> RequiredWords { get; set; }
    }
}
