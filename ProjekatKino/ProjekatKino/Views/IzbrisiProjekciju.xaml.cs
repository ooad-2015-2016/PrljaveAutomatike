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
    public sealed partial class IzbrisiProjekciju : Page
    {
        public IzbrisiProjekciju()
        {
            this.InitializeComponent();
            foreach(var trenutna in DataSource.DataSourceProjekatKino._projekcije)
            {
                comboBox.Items.Add(trenutna.VrijemeOdrzavanja);
            }
        }

        private async void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if(comboBox.SelectedIndex > -1)
            {
                DataSource.DataSourceProjekatKino._projekcije.Remove(DataSource.DataSourceProjekatKino._projekcije[comboBox.SelectedIndex]);
                var dialog = new Windows.UI.Popups.MessageDialog("Uspješno ste obrisali projekciju!", "Uspješno!");
                await dialog.ShowAsync();
                this.Frame.Navigate(typeof(ManagerForma));
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Niste odabrali niti jednu projekciju!", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ManagerForma));
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBoxFilm.Text = DataSource.DataSourceProjekatKino._projekcije[comboBox.SelectedIndex].FilmProjekcije.ime_filma;
            textBoxSala.Text = DataSource.DataSourceProjekatKino._projekcije[comboBox.SelectedIndex].Sala.NazivSale;
            textBoxCijena.Text = DataSource.DataSourceProjekatKino._projekcije[comboBox.SelectedIndex].CijenaProjekcije.ToString();
            textBlockCijena.Visibility = Visibility.Visible;
            textBlockFilm.Visibility = Visibility.Visible;
            textBlockSala.Visibility = Visibility.Visible;
            textBoxFilm.Visibility = Visibility.Visible;
            textBoxSala.Visibility = Visibility.Visible;
            textBoxCijena.Visibility = Visibility.Visible;
        }
    }
}
