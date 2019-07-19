using CubisMobilePortfolio.Services;
using CubisMobilePortfolio.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CubisMobilePortfolio.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            BusyIndicator.IsRunning = true;

            string xuser = txtUser.Text;
            string xpass = txtPass.Text;

            ApiData api = new ApiData();
            if (api.DoLogIn(xuser, xpass))
            {
                BusyIndicator.IsRunning = false;
                await Navigation.PopModalAsync();
            }
            else
            {
                txtPass.Text = "";
                BusyIndicator.IsRunning = false;
                await DisplayAlert("Prijava korisnika", "Neispravan unos korisničkog imena/ lozinke!", "OK");
            }
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        public async void OnLabelNewPassTapped(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new SendPassPage());
        }

        public async void OnLabelRegisterTapped(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new RegisterPage());
        }


    }
}