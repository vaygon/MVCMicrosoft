using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Play.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int PhotoId { get; set; }
        public string UserName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public virtual Photo Photo { get; set; }
    }
}