using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CubisMobilePortfolio.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void btnRegister_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        public async void OnLabelAlreadyTapped(object sender, EventArgs args)
        {
            //await Navigation.PushModalAsync(new LoginPage());
            await Navigation.PopModalAsync();
        }
    }
}