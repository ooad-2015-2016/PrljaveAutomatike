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
    public sealed partial class IzbrisiUposlenika : Page
    {
        public IzbrisiUposlenika()
        {
            this.InitializeComponent();
            foreach(Models.Korisnik korisnik in DataSource.DataSourceProjekatKino._korisnici)
            {
                comboBox.Items.Add(korisnik.Ime + " " + korisnik.Prezime);
            }                
        }

        private async void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBlock_Ime.Visibility = Windows.UI.Xaml.Visibility.Visible;
            textBlock_Prezime.Visibility = Windows.UI.Xaml.Visibility.Visible;
            textBlock_Podaci.Visibility = Windows.UI.Xaml.Visibility.Visible;
            textBlock_KorIme.Visibility = Windows.UI.Xaml.Visibility.Visible;

            textBox_Ime.PlaceholderText = DataSource.DataSourceProjekatKino._korisnici[comboBox.SelectedIndex].Ime;
            textBox_Prezime.PlaceholderText = DataSource.DataSourceProjekatKino._korisnici[comboBox.SelectedIndex].Prezime;
            textBox_KorIme.PlaceholderText = DataSource.DataSourceProjekatKino._korisnici[comboBox.SelectedIndex].KorisnickoIme;

            textBox_Ime.Visibility = Windows.UI.Xaml.Visibility.Visible;
            textBox_Prezime.Visibility = Windows.UI.Xaml.Visibility.Visible;
            textBox_KorIme.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }


    }
}
