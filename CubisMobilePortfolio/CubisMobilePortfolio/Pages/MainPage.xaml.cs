using CubisMobilePortfolio.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CubisMobilePortfolio
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            DoNavigation();
        }

        bool CheckLogin()
        {
            if (1 == 2)
                return true;
            else
                return false;
        }

        async void DoNavigation()
        {
            bool isResult = CheckLogin();
            if (!isResult)
                await Navigation.PushModalAsync(new LoginPage());
        }
    }
}
