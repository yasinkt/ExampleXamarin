using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleXamarin
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            btnLogin.Clicked += (sender, args) =>
            {
                if (UserName.Text != "test_username")
                {
                    DisplayAlert("UYARI", "Kullanıcı adı yanlış", "OK");
                    return;
                }
                
                if (Pass.Text != "test123")
                {
                    DisplayAlert("UYARI", "Şifre adı yanlış", "OK");
                    return;
                }

                Preferences.Set("IsLoggedIn", true);
                
                Navigation.PushModalAsync(new MainPage());
            };
        }
    }
}