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
    public sealed partial class DodajNamirnice : Page
    {
        bool izabrano = false;
        public DodajNamirnice()
        {
            this.InitializeComponent();
            comboBox.Items.Add("Hrana");
            comboBox.Items.Add("Pice");
        }

        private void buttonOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ManagerForma));
        }

        private async void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if(izabrano && textBoxCijena.Text != "" && textBoxIme.Text != "")
            {
                double cijena = double.Parse(textBoxCijena.Text.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                tipNamirnice tip = tipNamirnice.Pice;
                if (comboBox.SelectedItem.ToString() == "Hrana")
                    tip = tipNamirnice.Hrana;
                DataSource.DataSourceProjekatKino._namirnice.Add(new Models.Namirnica(textBoxIme.Text, cijena, tip));
                var dialog = new Windows.UI.Popups.MessageDialog("Uspješno ste dodali namirnicu!", "Uspješno!");
                await dialog.ShowAsync();
                this.Frame.Navigate(typeof(ManagerForma));
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Niste unijeli ispravno podatke!", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            izabrano = true;
        }
    }
}
