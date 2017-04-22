using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        // GET: Article/List
        public ActionResult List()
        {
            using(var db = new BlogDbContext())
            {
                // Get articles from DB
                var articles = db.Articles
                    .Include(a => a.Author)
                    .ToList();

                return View(articles);
            }
        }

        // GET: Article/Details
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using(var db = new BlogDbContext())
            {
                // Get the article from DB
                var article = db.Articles
                    .Where(a => a.Id == id)
                    .Include(a => a.Author)
                    .First();

                if(article == null)
                {
                    return HttpNotFound();
                }

                return View(article);
            }
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                using(var db = new BlogDbContext())
                {
                    // Get author id
                    var authorId = db.Users
                        .Where(u => u.UserName == this.User.Identity.Name)
                        .First()
                        .Id;

                    // Set articles author
                    article.AuthorId = authorId;

                    // Save article in DB
                    db.Articles.Add(article);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return View(article);
        }
    }
}