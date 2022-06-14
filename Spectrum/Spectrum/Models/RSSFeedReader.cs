
#region
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Spectrum.Models
{
    public class RSSFeedReader
    {

        public static List<News> NewsList { set; get; }
       
        public async Task<List<News>> readRSS(string url)
        {
            NewsList = new List<News>();
            using (HttpClient client = new HttpClient())
            {
                string baseAddress = url;
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();

                var uri = new Uri(string.Format(baseAddress, string.Empty));
                XmlDocument xmlDoc = new XmlDocument();

                var resp = await client.GetAsync(uri);
                if (resp.IsSuccessStatusCode)
                {
                    var xml = await resp.Content.ReadAsStringAsync();
                    XNamespace content = "URI";
                    var items = XDocument.Parse(xml)
                    .Descendants("item")
                    .Select(i => new
                    {
                        Title = (string)i.Element("title"),
                        Description = (string)i.Element("description"),
                        Link = (string)i.Element("link"),
                        Encoded = (string)i.Element(content + "encoded"),
                        PubDate = (string)i.Element("pubDate")
                    }).ToList().OrderBy(r => r.Title);


                    foreach (var item in items)
                    {
                        News n = new News();
                        n.Title = item.Title;
                        n.Link = item.Link;

                        string[] dateTime = item.PubDate.Split(' ');
                        string date = "";
                        for(int i=0; i<dateTime.Length-2; i++)
                        {
                            date += dateTime[i]+" ";
                        }

                        n.DatePublished = date;
                        
                        NewsList.Add(n);
                    }
                }
                else
                {

                }
            }
            return NewsList;
        }
    }

}
#endregion

