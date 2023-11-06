using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogCore.Identity
{
   public class ApplicationUser: Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string  Name { get; set; }
        public string LastName { get; set; }
    }
}
