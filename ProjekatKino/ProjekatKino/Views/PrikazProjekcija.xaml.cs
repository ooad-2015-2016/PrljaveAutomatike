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
    public sealed partial class PrikazProjekcija : Page
    {
        bool izabranaProjekcija = false;
        public PrikazProjekcija()
        {
            this.InitializeComponent();
            foreach(var trenutna in DataSource.DataSourceProjekatKino._projekcije)
            {
                if (trenutna.FilmProjekcije == DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1].filmKupovine && trenutna.ImaLiSlobodno)
                    comboBox.Items.Add(trenutna.VrijemeOdrzavanja);
            }
        }

        private async void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if (izabranaProjekcija)
            {
                foreach (var trenutna in DataSource.DataSourceProjekatKino._projekcije)
                {
                    int i = 0;
                    if (trenutna.FilmProjekcije == DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks() - 1].filmKupovine)
                    {
                        if (i == comboBox.SelectedIndex)
                        {
                            DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks() - 1].projekcija = trenutna;
                            DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks() - 1].cijenaRacuna = trenutna.CijenaProjekcije;
                            break;
                        }
                        i++;
                    }
                }
                this.Frame.Navigate(typeof(PrikazRacuna));
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Niste izabrali projekciju!", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }
        }

        private void buttonOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OdabirFilma));
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            izabranaProjekcija = true;
            textBlockCijena.Visibility = Visibility.Visible;
            textBlockFilm.Visibility = Visibility.Visible;
            textBlockSala.Visibility = Visibility.Visible;
            textBlock_Podaci.Visibility = Visibility.Visible;
            foreach (var trenutna in DataSource.DataSourceProjekatKino._projekcije)
            {
                int i = 0;
                if (trenutna.FilmProjekcije == DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks() - 1].filmKupovine)
                {
                    if (i == comboBox.SelectedIndex)
                    {
                        textBoxCijena.Text = trenutna.CijenaProjekcije.ToString();
                        textBoxFilm.Text = trenutna.FilmProjekcije.ime_filma;
                        textBoxSala.Text = trenutna.Sala.NazivSale;
                        break;
                    }
                    i++;
                }
            }
            textBoxCijena.Visibility = Visibility.Visible;
            textBoxFilm.Visibility = Visibility.Visible;
            textBoxSala.Visibility = Visibility.Visible;
        }
    }
}
