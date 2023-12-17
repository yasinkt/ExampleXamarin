using System.Collections.Generic;
using Xamarin.Forms;

namespace ExampleXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            var products = new List<Product>
            {
                new Product { Name = "Elma", Category = "Meyveler" },
                new Product { Name = "Brokoli", Category = "Sebzeler" },
                new Product { Name = "Tam Buğday Ekmeği", Category = "Fırın Ürünleri" },
                new Product { Name = "Cheddar Peyniri", Category = "Süt Ürünleri" },
                new Product { Name = "Yulaf Ezmesi", Category = "Kahvaltılık" },
                new Product { Name = "Domates", Category = "Sebzeler" },
                new Product { Name = "Tavuk Göğsü", Category = "Et Ürünleri" },
                new Product { Name = "Portakal Suyu", Category = "İçecekler" },
                new Product { Name = "Bitter Çikolata", Category = "Atıştırmalıklar" },
                new Product { Name = "Makarna", Category = "Kuru Gıdalar" },
                // Teknolojik ürünler
                new Product { Name = "Akıllı Telefon", Category = "Elektronik" },
                new Product { Name = "Dizüstü Bilgisayar", Category = "Bilgisayarlar" },
                new Product { Name = "Kablosuz Kulaklık", Category = "Aksesuarlar" },
                new Product { Name = "Akıllı Saat", Category = "Giyilebilir Teknoloji" },
                new Product { Name = "E-Kitap Okuyucu", Category = "Okuma Cihazları" },
                new Product { Name = "Tablet", Category = "Mobil Cihazlar" },
                new Product { Name = "Oyun Konsolu", Category = "Eğlence" },
                new Product { Name = "Kablosuz Şarj Cihazı", Category = "Güç Çözümleri" },
                new Product { Name = "Akıllı Ev Asistanı", Category = "Akıllı Ev" },
                new Product { Name = "Fitness Takip Cihazı", Category = "Spor Aksesuarları" },
            };

            productsListView.ItemsSource = products;
        }
    }
}

