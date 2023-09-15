using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Domain
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}