using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjekatKino
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
            //inicijalizacija data source
            var inicijalizacija = new DataSource.DataSourceMenuMD();
        }

        //asinhrona metoda za provjeru prijave korisnika
        private async void button_LoginClick(object sender, RoutedEventArgs e)
        {
            var korisnickoIme = usernameBox.Text;
            var sifra = passwordBox.Password;
            var korisnik = DataSource.DataSourceMenuMD.ProvjeraKorisnika(korisnickoIme, sifra);
            if (korisnik != null && korisnik.KorisnikId >=1 && korisnik.KorisnikId!= 2)
            {
                this.Frame.Navigate(typeof(OdabirFilma), korisnik);
            }
            else if (korisnik != null && korisnik.KorisnikId ==2)
            {
                this.Frame.Navigate(typeof(RadnikIzbor), korisnik);
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Pogrešno korisničko ime/šifra!", "Neuspješna prijava");
                await dialog.ShowAsync();
            }
        }
    }
}
