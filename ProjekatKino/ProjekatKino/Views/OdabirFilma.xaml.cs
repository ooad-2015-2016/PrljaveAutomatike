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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjekatKino
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OdabirFilma : Page
    {
        bool filmJeIzabran = false;
        public OdabirFilma()
        {
            this.InitializeComponent();
            foreach (var trenutni in DataSource.DataSourceProjekatKino._filmovi)
            {
                comboBoxFilmovi.Items.Add(trenutni.ime_filma);
            }
        }


        private async void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            //Ako nije odabran niti jedan film ne daj klik potvrdi
            if (!filmJeIzabran)
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Niste odabrali niti jedan film!", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }
            else
            {
                DataSource.DataSourceProjekatKino._kupovine.Add(new Models.Kupovina());
                DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1].datumKupovine = DateTime.Today;
                DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1].filmKupovine = DataSource.DataSourceProjekatKino._filmovi[comboBoxFilmovi.SelectedIndex];
                bool pronadjen = false;
                if(textBoxJMBG.IsEnabled && textBoxJMBG.Text.Length != 13)
                {
                    var dialog = new Windows.UI.Popups.MessageDialog("Niste unijeli tačan JMBG!", "Pokušajte ponovo!");
                    await dialog.ShowAsync();
                }
                if(!textBoxJMBG.IsEnabled)
                {
                    DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1].posjetitelj = null;
                    DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1].TipPosjetitelja = tipPosjetitelja.Neuclanjen;
                    this.Frame.Navigate(typeof(Views.PrikazProjekcija));
                }
                if (textBoxJMBG.IsEnabled && textBoxJMBG.Text.Length == 13)
                {
                    foreach(var trenutni in DataSource.DataSourceProjekatKino._registrovaniClanovi)
                    {
                        if (trenutni.JMBG == textBoxJMBG.Text)
                        {
                            DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1].posjetitelj = trenutni;
                            pronadjen = true;
                            break;
                        }
                    }
                    if(!pronadjen)
                    {
                        var dialog = new Windows.UI.Popups.MessageDialog("Ne postoji clan sa unesenim JMBG!", "Pokušajte ponovo!");
                        await dialog.ShowAsync();
                    }
                    else
                    {
                        DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1].TipPosjetitelja = tipPosjetitelja.Uclanjen;
                        this.Frame.Navigate(typeof(Views.PrikazProjekcija));
                    }
                }

                    
            }
        }

        private void checkBoxClan_Checked(object sender, RoutedEventArgs e)
        {
            textBoxJMBG.IsEnabled = true;
            textBoxJMBG.Visibility = Visibility.Visible;
        }
        private void checkBoxClan_Unchecked(object sender, RoutedEventArgs e)
        {
            textBoxJMBG.IsEnabled = false;
            textBoxJMBG.Visibility = Visibility.Collapsed;
        }
        private void buttonOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RadnikIzbor));
        }

        private async void comboBoxFilmovi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filmJeIzabran = true;
            //Izabrani film je DataSource.DataSourceProjekatKino._filmovi[comboBoxFilmovi.SelectedIndex]
            //prikazi detaljnije opcije za odabrani film
            textBlockPodaci.Visibility = Visibility.Visible;
            textBlockImeFilma.Visibility = Visibility.Visible;
            textBlockFilmId.Visibility = Visibility.Visible;
            textBlockTrajanje.Visibility = Visibility.Visible;
            textBoxImeFilma.Text = DataSource.DataSourceProjekatKino._filmovi[comboBoxFilmovi.SelectedIndex].ime_filma;
            textBoxTrajanje.Text = DataSource.DataSourceProjekatKino._filmovi[comboBoxFilmovi.SelectedIndex].trajanje.ToString() + " min";
            textBoxFilmId.Text = DataSource.DataSourceProjekatKino._filmovi[comboBoxFilmovi.SelectedIndex].FilmId.ToString();
            textBoxFilmId.Visibility = Visibility.Visible;
            textBoxImeFilma.Visibility = Visibility.Visible;
            textBoxTrajanje.Visibility = Visibility.Visible;
            textBlockOdaberite.Visibility = Visibility.Visible;
            checkBoxPenzioner.Visibility = Visibility.Visible;
            checkBoxStudent.Visibility = Visibility.Visible;
            checkBoxClan.Visibility = Visibility.Visible;
            textBlockTrajanje.Visibility = Visibility.Visible;
        }
    }
}
