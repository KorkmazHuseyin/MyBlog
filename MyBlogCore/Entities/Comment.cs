using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogCore.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public DateTime CommentDate { get; set; }
        public float Rate { get; set; }
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
