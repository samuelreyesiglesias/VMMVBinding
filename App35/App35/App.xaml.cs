using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App35.View;
namespace App35
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var paagina = new EstudianteView();
            MainPage = new NavigationPage(paagina);
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
