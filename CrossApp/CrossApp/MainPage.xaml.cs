using System;
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
        
	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new NavigationPage(new SecondPage())); // Navigate to another page using async
            NavigationPage.SetHasNavigationBar(this, false);  // Hide nav bar
        }
	}
}
