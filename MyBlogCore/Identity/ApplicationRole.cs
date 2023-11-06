using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogCore.Identity
{
  public class ApplicationRole: Microsoft.AspNetCore.Identity.IdentityRole
    {
        public string Description { get; set; }
        public ApplicationRole()
        {

        }
        public ApplicationRole(string roleName,string description)
        {
            this.Description = description;
        }
    }
}
