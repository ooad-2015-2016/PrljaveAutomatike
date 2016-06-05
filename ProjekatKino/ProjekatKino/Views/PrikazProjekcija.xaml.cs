﻿using System;
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
                if (trenutna.FilmProjekcije == DataSource.DataSourceProjekatKino._kupovine.Last().filmKupovine)
                    comboBox.Items.Add(trenutna.VrijemeOdrzavanja);
            }
        }

        private async void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if (izabranaProjekcija)
            {
                DataSource.DataSourceProjekatKino._kupovine.Last().projekcija = DataSource.DataSourceProjekatKino._projekcije[comboBox.SelectedIndex];
                DataSource.DataSourceProjekatKino._kupovine.Last().cijenaRacuna += DataSource.DataSourceProjekatKino._projekcije[comboBox.SelectedIndex].CijenaProjekcije;
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
        }
    }
}
