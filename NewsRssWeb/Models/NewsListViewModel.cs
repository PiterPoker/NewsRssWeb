using NewsRssWeb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsRssWeb.Models
{
    public class NewsListViewModel
    {
        public IEnumerable<News> NewsList { get; set; }
        public SelectList GeneratorList { get; set; }
    }
}