using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MixocityApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void SubmitClicked(object sender, EventArgs e)
        {
            var Username = txtUsername.Text;
            var Email = txtEmailAddress.Text;
            var Password = txtPassword.Text;
            var ConfirmPass = txtConfirmPassword.Text;

            // User Submission Validation Checks

             if (Password != ConfirmPass && Password !=null && ConfirmPass != null)
            {
                DisplayAlert("Oops..", "Invalid Password", "Ok");
            }
            if (Username == Password || Username == ConfirmPass) 
            {
                DisplayAlert("Oops..", "Username cant be same as password", "Ok");
            }
            if(Username == null || Email == null || Password == null || ConfirmPass == null )
            {
                DisplayAlert("Oops..", "Please fill out all fields", "Ok");
            }

            if (Username != null && Email != null && Password != null && Password == ConfirmPass && Password != Username && ConfirmPass != Username && ConfirmPass != null)
            {

                Navigation.PushAsync(new SubmittedPage());

            }
        }
    }
}