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
    public sealed partial class DodajProjekciju : Page
    {
        public DodajProjekciju()
        {
            this.InitializeComponent();
            foreach(var trenutno in DataSource.DataSourceProjekatKino._filmovi)
            {
                comboBoxFilm.Items.Add(trenutno.ime_filma);
            }
            foreach (var trenutno in DataSource.DataSourceProjekatKino._sale)
            {
                comboBoxSala.Items.Add(trenutno.NazivSale);
            }
        }

        private async void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxCijena.Text != "" && comboBoxFilm.SelectedIndex > -1 && comboBoxSala.SelectedIndex > -1)
            {
                double cijena = double.Parse(textBoxCijena.Text.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                Models.KinoSala Sala = DataSource.DataSourceProjekatKino._sale[comboBoxSala.SelectedIndex];
                Models.Film FilmProjekcije = DataSource.DataSourceProjekatKino._filmovi[comboBoxFilm.SelectedIndex];
                DateTime VrijemeOdrzavanja = datePickerDatum.Date.DateTime + timePickerVrijeme.Time;

                DataSource.DataSourceProjekatKino._projekcije.Add(new Models.Projekcija(FilmProjekcije, Sala, VrijemeOdrzavanja, cijena));

                var dialog = new Windows.UI.Popups.MessageDialog("Uspješno ste dodali projekciju!", "Uspješno!");
                await dialog.ShowAsync();
                this.Frame.Navigate(typeof(ManagerForma));
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Niste unijeli tačno podatke o projekciji!", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }
        }

        private void buttonOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ManagerForma));
        }
    }
}
