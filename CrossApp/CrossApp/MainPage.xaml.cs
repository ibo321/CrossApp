﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void Button_OnPressed(object sender, EventArgs e)
	    {
	        DisplayAlert("Display dialog", "Det virker", "CLOSE");
	    }
	}
}
