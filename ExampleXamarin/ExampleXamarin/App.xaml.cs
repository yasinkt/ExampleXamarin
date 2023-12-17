using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleXamarin
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            if (Preferences.Get("IsLoggedIn", false))
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new Login();
            }
            
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

