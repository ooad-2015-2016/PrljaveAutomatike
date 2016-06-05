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
    public sealed partial class DodajUposlenika : Page
    {
        public DodajUposlenika()
        {
            this.InitializeComponent();
            comboBox.Items.Add("Običan uposlenik");
            comboBox.Items.Add("Menadžer");
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ManagerForma));
        }

        private async void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxIme.Text != "" && textBoxPrezime.Text != "" && textBoxKorIme.Text != "" && textBoxSifra.Text != "" && (comboBox.SelectedIndex > -1))
            {
                //ovdje implementirati sacuvavanje uposlenika
                int ID = 0;
                if (comboBox.SelectedItem.ToString() != "Menadžer")
                {
                    ID = DataSource.DataSourceProjekatKino.pdb.Korisnici.Count() + 1;
                    DataSource.DataSourceProjekatKino.pdb.Korisnici.Add(new Models.Korisnik { Ime = textBoxIme.Text, Prezime = textBoxPrezime.Text, KorisnickoIme = textBoxKorIme.Text, Sifra = textBoxSifra.Text, KorisnikId = ID });
                }
                else if (comboBox.SelectedItem.ToString() == "Menadžer")
                {
                    ID = DataSource.DataSourceProjekatKino.pdb.Menadzeri.Count() + 1;
                    DataSource.DataSourceProjekatKino.pdb.Menadzeri.Add(new Models.Menadzer { Ime = textBoxIme.Text, Prezime = textBoxPrezime.Text, KorisnickoIme = textBoxKorIme.Text, Sifra = textBoxSifra.Text, KorisnikId = ID });

                }
                var dialog = new Windows.UI.Popups.MessageDialog("Uspjesno ste registrovali novog uposlenika!", "Uspjesna registracija!");
                await dialog.ShowAsync();
                this.Frame.Navigate(typeof(ManagerForma));

            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Niste ispravno unijeli podatke o uposleniku ili ste zaboravili odabrati tip uposlenika", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }
        }
    }
}