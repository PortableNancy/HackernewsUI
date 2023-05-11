using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HackernewsUI.Domain.Dto
{
    public class CommentDto
    {
        public Guid Id = Guid.NewGuid();
        public string Username { get; set; }
        public DateTimeOffset DatePosted = DateTimeOffset.Now;
        public string Comment { get; set; }
    }
}
