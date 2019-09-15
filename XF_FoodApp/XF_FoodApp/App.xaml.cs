using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_FoodApp.Services;
using XF_FoodApp.Views;

namespace XF_FoodApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MainService>();
            MainPage = new AppShell();
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
    }
}
