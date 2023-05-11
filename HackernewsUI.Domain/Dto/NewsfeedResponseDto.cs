using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HackernewsUI.Domain.Dto
{
    public class NewsfeedResponseDto
    {
        public string Headline { get; set; }
        public DateTimeOffset Posted = DateTimeOffset.Now;
    }
}
}
