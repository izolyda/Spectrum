﻿using System;
using System.Collections.Generic;
using System.Threading;
using Spectrum.Models;
using Xamarin.Forms;

namespace Spectrum.Views
{	
	public partial class CategoriesView : ContentPage
	{
		List<News> news;
		RSSFeedReader reader = new RSSFeedReader();

        public CategoriesView ()
		{
			InitializeComponent ();
            lstCategoriesView.BindingContext = Data.Categories.CategoryList;
		}


        async void lstCategoriesView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
		
			var category = e.Item as Category;

			news = await reader.readRSS(category.URL);

			await Navigation.PushAsync(new NewsFeedView(news));
			lstCategoriesView.SelectedItem = null;
		}

        void lstCategoriesView_Refreshing(System.Object sender, System.EventArgs e)
        {
			lstCategoriesView.EndRefresh();
		}
    }
}

