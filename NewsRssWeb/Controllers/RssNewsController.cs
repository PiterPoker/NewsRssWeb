using NewsRssWeb.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using PagedList;

namespace NewsRssWeb.Controllers
{
    public class RssNewsController : Controller
    {
        ApplicationContext db = new ApplicationContext();

        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page, int? generatorId)
        {
            ViewBag.GeneratorId = generatorId;
            ViewBag.CurrentSort = sortOrder;

            IQueryable<News> news = from s in db.News.Include(p => p.Generator)
                                    select s;
            if (generatorId != null && generatorId != 0)
            {
                news = news.Where(p => p.GeneratorId == generatorId);
            }

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            

            if (!String.IsNullOrEmpty(searchString))
            {
                news = news.Where(s => s.Title.Contains(searchString)
                                       || s.Title.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "date_Desc":
                    news = news.OrderByDescending(s => s.DatePublication);
                    break;
                case "Title":
                    news = news.OrderBy(s => s.Generator.Name);
                    break;
                default:
                    news = news.OrderBy(s => s.Id);
                    break;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);           

            List<Generator> generator = db.Generators.ToList();
            generator.Insert(0, new Generator {  Name = "Все", Id = 0 });
            var ListGenerator = new SelectList(generator, "Id", "Name");
            ViewBag.ListGenerator = ListGenerator;
            return View(news.ToPagedList(pageNumber, pageSize));
        }
    }
}