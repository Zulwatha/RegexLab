using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexLab.Models
{
    internal class RegexPattern
    {
        public string Title { get; set; }
        public string Pattern { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
    }
}
