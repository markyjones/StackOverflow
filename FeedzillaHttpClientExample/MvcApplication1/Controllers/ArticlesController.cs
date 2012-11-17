using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class ArticlesController : ApiController
    {
        public class Enclosure
        {
            public int length { get; set; }
            public string media_type { get; set; }
            public string uri { get; set; }
        }

        public class Article
        {
            public string author { get; set; }
            public string publish_date { get; set; }
            public string source { get; set; }
            public string source_url { get; set; }
            public string summary { get; set; }
            public string title { get; set; }
            public string url { get; set; }
            public List<Enclosure> enclosures { get; set; }
        }

        public class RootObject
        {
            public List<Article> articles { get; set; }
            public string description { get; set; }
            public string syndication_url { get; set; }
            public string title { get; set; }
        }

        public IEnumerable<Article> Get()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.feedzilla.com/v1/");

            //Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // call the REST method
            HttpResponseMessage response = client.GetAsync("http://api.feedzilla.com/v1/categories/2/articles.json??count=36&since=2012-11-15&client_source=&order=relevance&title_only=0&").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<RootObject>().Result.articles;
            }
            else
            {
                return null;   
            }
        }
    }
}