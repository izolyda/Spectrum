using System;
using System.Collections.Generic;
using Spectrum.Models;

namespace Spectrum.Data
{
	public class NewsFactory
	{
		public static List<News> NewsList { get; }

		static NewsFactory()
		{
			NewsList = new List<News>
			{
				new News{ Title = "Biden", CategoryTitle=News.NewsCategory.Politics},
				new News{ Title = "Putin", CategoryTitle=News.NewsCategory.Politics},
				new News{ Title = "Tennis", CategoryTitle=News.NewsCategory.Sports},
				new News{ Title = "Bach prelude", CategoryTitle=News.NewsCategory.Culture},
				new News{ Title = "IBM Quantum Computer", CategoryTitle=News.NewsCategory.Tech},
				new News{ Title = "War in Afghanistan", CategoryTitle=News.NewsCategory.Foreign},
				new News{ Title = "CAR-T cell therapy", CategoryTitle=News.NewsCategory.Science },
			};

		}
	}
}

