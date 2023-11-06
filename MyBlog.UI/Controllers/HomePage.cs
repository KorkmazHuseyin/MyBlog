using Microsoft.AspNetCore.Mvc;
using MyBlogCore.Context;
using MyBlogCore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyBlog.UI.Controllers
{
    public class HomePage : Controller
    {
        BlogDbContext db = new BlogDbContext();
        public IActionResult Home()
        {
            var Article = db.Article.Where(a => a.Approval == true).Select(a=>new ArticleDTO() { 
            
            Id=a.Id,
            Header=a.Header,
            UserName=a.UserName,
            Photo=a.Photo,
            EditionTime=a.EditionTime,
            Approval=a.Approval,
            ViewCount=a.ViewCount,
            Comment=a.Comment,
            Description=a.Description.Length>60 ?a.Description.Substring(0,60)+("[...]"):a.Description
            
            }).ToList();
            return View(Article);
        }
        public ActionResult ArticleDetail(int Id)
        {
            var Article = db.Article.Find(Id);
            ViewBag.article = Article;
            return View();
        }
    }
}
