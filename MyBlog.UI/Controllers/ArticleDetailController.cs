using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.Controllers
{
    public class ArticleDetailController : Controller
    {
        public IActionResult ArticleDetail()
        {
            return View();
        }
    }
}
