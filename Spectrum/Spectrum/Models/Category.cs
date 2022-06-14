using System;
using System.Collections.Generic;

namespace Spectrum.Models
{
	public class Category
	{

		public string CategoryName { get; set; }

		public string ImagePath { get => CategoryName + ".png"; }

		public string URL { get; set; }

		public Category()
		{

		}

	}
}

