using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HackernewsUI.Domain.Models
{
    public class Comments
    {
        public Guid Id = Guid.NewGuid();
        public string Username { get; set; }
        public DateTimeOffset DatePosted = DateTimeOffset.Now;  
        public string Comment { get; set; }
        
    }
}
