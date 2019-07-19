using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CubisMobilePortfolio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            InitApplicationProperties();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void InitApplicationProperties()
        {
            Application.Current.Properties["ClientCompany"] = AppSettingsManager.Settings["ClientCompany"];

            /* Definiranje Base Api URL */
            switch (Application.Current.Properties["ClientCompany"].ToString())
            {
                case "UNIQA_TEST":
                    Application.Current.Properties["BaseApiUrl"] = AppSettingsManager.Settings["SERVICE_UNIQA_TEST"];
                    break;
                case "OSIG_UNIQA_TEST":
                    Application.Current.Properties["BaseApiUrl"] = AppSettingsManager.Settings["SERVICE_OSIG_UNIQA_TEST"];
                    break;
                case "WIENER_TEST":
                    Application.Current.Properties["BaseApiUrl"] = AppSettingsManager.Settings["SERVICE_WIENER_TEST"];
                    break;
                case "OSIG_WIENER_TEST":
                    Application.Current.Properties["BaseApiUrl"] = AppSettingsManager.Settings["SERVICE_OSIG_WIENER_TEST"];
                    break;
            }
        }
    }
}
