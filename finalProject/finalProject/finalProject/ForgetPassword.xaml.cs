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
    public partial class ForgetPassword : ContentPage
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }
    private async void handleResetLink(object sender, EventArgs e)
        {
            if (resetMail.Text == "admin")
            {
                await Navigation.PushAsync(new MainPage());
                await DisplayAlert("Link Sent!", "Reset link is sent to your email address.", "Ok");
            }
            else
            {
                await DisplayAlert("Reset Link Failed!", "Email address not registered.", "Ok");
            }
        }
    }
}