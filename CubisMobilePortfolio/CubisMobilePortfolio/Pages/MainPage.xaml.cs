using CubisMobilePortfolio.ViewModel;
using CubisMobilePortfolio.Pages;
using CubisMobilePortfolio.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Meni> Menus;
        public static bool First = true;

        public MainPage()
        {
            InitializeComponent();

            DoNavigation();

            DrawItems();
        }
        async void DoNavigation()
        {
            /* Kod prve prijave sprema GUID lokalno */
            bool isResult = ExistLogin();
            bool isPreservedLogin = AppSettingsManager.Settings["PreserveLogin"].ToString().Trim().ToLower() == "true";

            if (!isResult || !isPreservedLogin)
                await Navigation.PushModalAsync(new LoginPage());
        }

        private void DrawItems()
        {
            Menus = new ObservableCollection<Meni>();

            if (First)
            {
                ApiMockData apiMock = new ApiMockData();
                var menus = apiMock.GetMenu();

                foreach (var m in menus)
                {
                    Menus.Add(m);
                }

                LvMenu.ItemsSource = Menus;
                BusyIndicator.IsRunning = false;
            }

            First = false;
        }

        bool ExistLogin()
        {
            if (Application.Current.Properties.ContainsKey("GUID"))
            {
                return true;
            }
            else
                return false;
        }

    }
}
