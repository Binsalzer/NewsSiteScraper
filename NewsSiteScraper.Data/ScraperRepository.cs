using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSiteScraper.Data
{
    public class ScraperRepository
    {
        private readonly string _connection;

        public ScraperRepository(string connection)
        {
            _connection = connection;
        }

        private string GetHtml(string url)
        {
            var client = new HttpClient();
            return client.GetStringAsync(url).Result;
        }

        public List<Headline> GetHeadlines()
        {
            var headlines = new List<Headline>();

            var html = GetHtml("https://thelakewoodscoop.com/");
            var parser = new HtmlParser();
            var document = parser.ParseDocument(html);
            var divs = document.QuerySelectorAll("div.td-module-container ");


            foreach (AngleSharp.Dom.IElement div in divs)
            {
                //title
                var titleElement = div.QuerySelector("h3.entry-title");

                //anchor tag
                var anchorTag = titleElement.QuerySelector("a").Attributes["href"].Value;

                //image url
                var imageUrl = div.QuerySelector("span.entry-thumb").Attributes["data-img-url"].Value;

                //CommentCount
                var commentCount = div.QuerySelector("span.td-module-comments").QuerySelector("a").TextContent;

                //Blurb
                var blurb = div.QuerySelector("div.td-excerpt").TextContent;

                headlines.Add(new()
                {
                    Title=titleElement.TextContent,
                    ArticleUrl=anchorTag,
                    ImageUrl=imageUrl,
                    CommentCount=int.Parse(commentCount),
                    BlurbText=blurb
                });
            }

            return headlines;
        }
    }
}
