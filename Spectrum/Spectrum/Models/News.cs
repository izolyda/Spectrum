using System;
using System.Diagnostics;

namespace Spectrum.Models
{
	public class News
	{
		
        public string Title { get; set; }
		public string Link { get; set; }
		public string DatePublished { get; set; }
        

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

