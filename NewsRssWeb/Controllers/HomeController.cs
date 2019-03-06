using NewsRssWeb.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsRssWeb.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db = new ApplicationContext();

        public ActionResult AutocompleteSearch(string term)
        {
            var models = db.News.Where(a => a.Link.Contains(term))
                            .Select(a => new { value = a.Link })
                            .Distinct();

            return Json(models, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            var news = db.News;
            return View(news);
        }

        public string GetData()
        {
            return JsonConvert.SerializeObject(db.News.First());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}