using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace finalProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private async void handleLogout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void OnFrameTapped(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new RecipePage());
        }
        private async void OnTappedHandler(object sender, EventArgs e)
        {
            await DisplayAlert("Logout!", "Are you sure you want to logout?", "Yes");
            await Navigation.PushAsync(new MainPage());
        }
    }
}