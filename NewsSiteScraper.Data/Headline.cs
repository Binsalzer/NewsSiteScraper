using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSiteScraper.Data
{
    public class Headline
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string BlurbText { get; set; }
        public int CommentCount { get; set; }
        public string ArticleUrl { get; set; }
    }
}
