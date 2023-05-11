using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HackernewsUI.Domain.Models
{
    public class Newsfeed
    {
        public string Headline { get; set; }
        public DateTimeOffset Posted = DateTimeOffset.Now;
    }
}
