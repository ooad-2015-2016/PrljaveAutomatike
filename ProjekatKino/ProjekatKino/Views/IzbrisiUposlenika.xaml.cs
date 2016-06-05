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

    public sealed partial class IzbrisiUposlenika : Page
    {
        bool nekoJeIzabranIzComboBoxa = false;
        public IzbrisiUposlenika()
        {
            this.InitializeComponent();
            //Ova petelja popunjava combobox sa uposlenicima
            foreach(Models.Korisnik korisnik in DataSource.DataSourceProjekatKino.pdb.Korisnici)
            {
                comboBox.Items.Add(korisnik.Ime + " " + korisnik.Prezime);
            }             
        }
        //mora biti async funkcija, ukoliko se neko izabere iz dropdowna
        private async void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            nekoJeIzabranIzComboBoxa = true;
            textBlock_Ime.Visibility = Windows.UI.Xaml.Visibility.Visible;
            textBlock_Prezime.Visibility = Windows.UI.Xaml.Visibility.Visible;
            textBlock_Podaci.Visibility = Windows.UI.Xaml.Visibility.Visible;
            textBlock_KorIme.Visibility = Windows.UI.Xaml.Visibility.Visible;

            textBox_Ime.Text = DataSource.DataSourceProjekatKino.pdb.Korisnici[comboBox.SelectedIndex].Ime;
            textBox_Prezime.Text = DataSource.DataSourceProjekatKino.pdb.Korisnici[comboBox.SelectedIndex].Prezime;
            textBox_KorIme.Text = DataSource.DataSourceProjekatKino.pdb.Korisnici[comboBox.SelectedIndex].KorisnickoIme;

            

            textBox_Ime.Visibility = Windows.UI.Xaml.Visibility.Visible;
            textBox_Prezime.Visibility = Windows.UI.Xaml.Visibility.Visible;
            textBox_KorIme.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }
        //Dalje treba implementirati da se obrise izabrani korisnik
        private async void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if(nekoJeIzabranIzComboBoxa)
            {
                //Ovdje implementirati brisanje korisnika DataSource.DataSourceProjekatKino._korisnici[comboBox.SelectedIndex]
                DataSource.DataSourceProjekatKino.pdb.Korisnici.Remove(DataSource.DataSourceProjekatKino.pdb.Korisnici[comboBox.SelectedIndex]);
                this.Frame.Navigate(typeof(ManagerForma));
            }
            else
            {
                //Javljanje greske ako niko nije izabran, a kliknuto je potvrdi
                var dialog = new Windows.UI.Popups.MessageDialog("Niste odabrali niti jednog uposlenika!", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ManagerForma));
        }
    }
}
