using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewsRssWeb.Entity
{
    public class Generator
    {
        public int? Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }

        public TuningGenerator TuningGenerator { get; set; }
        public ICollection<News> ListNews { get; set; }
        public Generator()
        {
            ListNews = new List<News>();
        }
    }
}