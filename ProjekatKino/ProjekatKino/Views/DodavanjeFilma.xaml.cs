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
    public sealed partial class DodavanjeFilma : Page
    {
        public DodavanjeFilma()
        {
            this.InitializeComponent();
        }

        private async void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxFilmId.Text == "" || textBoxIme.Text   == "" || textBoxTrajanje.Text == "")
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Niste unijeli tačno podatke o filmu!", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }
            else
            {
                int id = Convert.ToInt32(textBoxFilmId.Text);
                int trajanje = Convert.ToInt32(textBoxTrajanje.Text);
                DataSource.DataSourceProjekatKino._filmovi.Add(new Models.Film(id, textBoxIme.Text, trajanje));
                var dialog = new Windows.UI.Popups.MessageDialog("Uspješno ste dodali film!", "Uspješno!");
                await dialog.ShowAsync();
                this.Frame.Navigate(typeof(ManagerForma));
            }
        }

        private void buttonOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ManagerForma));
        }
    }
}
