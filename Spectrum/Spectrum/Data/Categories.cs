using System;
using System.Collections.Generic;
using Spectrum.Models;

namespace Spectrum.Data
{
	public class Categories
	{
		public static List<Category> CategoryList { get; }

		
		static Categories()
		{
			CategoryList = new List<Category>
			{
				new Category{ CategoryName = "Politics", URL = "https://politicususa.com/feed" },
				new Category{ CategoryName = "Social", URL = "https://socialmediatoday.com/feeds/news" },
				new Category{ CategoryName = "Finance", URL = "https://ft.com/?format=rss" },
				new Category{ CategoryName = "Tech", URL = "https://techcrunch.com/feed" },
				new Category{ CategoryName = "Science", URL = "https://scienceblog.com/feed" },
				new Category{ CategoryName = "Culture", URL = "https://bbc.com/culture/feed.rss" },
				new Category{ CategoryName = "Sports", URL = "https://sportingnews.com/us/rss" },
				new Category{ CategoryName = "Weather", URL = "https://rssweather.com" },
				new Category{ CategoryName = "Foreign", URL = "https://feeds.bbci.co.uk/news/world/rss.xml" },

			};

			
		}
	}
}

