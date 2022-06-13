using System;
using System.Diagnostics;

namespace Spectrum.Models
{
	public class News
	{
		public enum NewsCategory{ Politics, Social, Finance, Tech, Science, Culture, Sports, Weather, Foreign }
        public string Title { get; set; }
		public string Link { get; set; }
        public NewsCategory CategoryTitle { get; set; }


        public News(string Title, string Link)
		{
			this.Link = Link;
			this.Title = Title;
		}

		public News()
        {
			
		}
	}
}

