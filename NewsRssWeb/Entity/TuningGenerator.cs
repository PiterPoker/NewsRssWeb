using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewsRssWeb.Entity
{
    public class TuningGenerator
    {
        [Key]
        [ForeignKey("Generator")]
        public int Id { get; set; }
        public string UriString { get; set; }
        public string FormatTime { get; set; }
        public DateTime DateWrite { get; set; } = DateTime.MinValue;
        public string TitleLastPost { get; set; }
        public string LinkLastPost { get; set; }

        //public int GeneratorId { get; set; }
        public Generator Generator { get; set; }
    }
}