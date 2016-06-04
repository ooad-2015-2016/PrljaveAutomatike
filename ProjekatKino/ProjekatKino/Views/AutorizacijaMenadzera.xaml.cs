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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatKino.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AutorizacijaMenadzera : Page
    {
        public AutorizacijaMenadzera()
        {
            this.InitializeComponent();
        }

        private async void button_LoginClick(object sender, RoutedEventArgs e)
        {
            var korisnickoIme = usernameBox.Text;
            var sifra = passwordBox.Password;
            var korisnik = DataSource.DataSourceProjekatKino.ProvjeraKorisnika(korisnickoIme, sifra);
            if (korisnik != null && korisnik.KorisnikId == 5)
            {
                //Autorizacija je dobro prosla, obrisi ovog uposlenika, IMPLEMENTIRATI (korisnik je poslan u formu)
            }
            if (korisnik != null)
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Neispravna autorizacija", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }
        }
        private void button_OdustaniClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ManagerForma), e);
        }
    }
}
