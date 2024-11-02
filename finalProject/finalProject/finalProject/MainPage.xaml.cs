using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace finalProject
{
    public partial class MainPage : ContentPage
    {
        private bool isPasswordVisible = false;
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            

        }

        private void Show_Password(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            // Update Entry's IsPassword property based on visibility state
            passwordEntry.IsPassword = !isPasswordVisible;

            // Update button text based on current state
            (sender as Button).Text = isPasswordVisible ? "Hide Password" : "Show Password";
        }
        private  void handleLogin(object sender, EventArgs e)
        {
            if (emailEntry.Text == "admin" & passwordEntry.Text == "admin"){
                Navigation.PushAsync(new HomePage());
                emailEntry.Text = string.Empty;
                passwordEntry.Text = string.Empty;
            }
            else
            {
                 DisplayAlert("Login Failed!","Invalid username or password","OK");
            }
           
        }
        private async void handleForgetPass(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgetPassword());
        }
    }
}
