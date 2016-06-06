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
using ProjekatKino.Helper;

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
            var inicijalizacija = new DataSource.DataSourceProjekatKino();
        }
        Rfid rfid = new Rfid();
        //asinhrona metoda za provjeru prijave korisnika
        private async void button_LoginClick(object sender, RoutedEventArgs e)
        {
            //usernameBox.Text = rfid.CurrentReadString;
            var korisnickoIme = usernameBox.Text;
            var sifra = passwordBox.Password;
            var korisnik = DataSource.DataSourceProjekatKino.pdb.ProvjeraKorisnika(korisnickoIme, sifra);
            var menadzer = DataSource.DataSourceProjekatKino.pdb.ProvjeraMenadzera(korisnickoIme, sifra);

            if (korisnik != null && korisnik.KorisnikId == 1)
            {
                this.Frame.Navigate(typeof(GPSView), korisnik);
            }
            else if (korisnik != null && korisnik.KorisnikId >= 1)
            {
                this.Frame.Navigate(typeof(RadnikIzbor), korisnik);
            }
            else if (menadzer != null && menadzer.KorisnikId >= 1)
            {
                this.Frame.Navigate(typeof(ManagerForma), menadzer);
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Pogrešno korisničko ime/šifra!", "Neuspješna prijava");
                await dialog.ShowAsync();
            }
        }
        //OVDJE TE SALJE NA GPS VIEW
        private void buttonGPS_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GPSView));
        }
    }
}