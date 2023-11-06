using MyBlogCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogCore.DTO
{
   public class ArticleDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Header { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public DateTime EditionTime { get; set; }
        public int ViewCount { get; set; }
        public bool Approval { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
    }
}
