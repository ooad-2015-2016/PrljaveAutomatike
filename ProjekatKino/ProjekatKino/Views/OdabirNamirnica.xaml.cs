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
    public sealed partial class OdabirNamirnica : Page
    {
        int kolicinaHrane = 1;
        int kolicinaPica = 1;
        public OdabirNamirnica()
        {
            this.InitializeComponent();
            foreach(var hrana in DataSource.DataSourceProjekatKino._namirnice)
            {
                if (hrana.TipNamirnice == tipNamirnice.Hrana)
                    comboBoxHrana.Items.Add(hrana.ImeNamirnice);
            }
            foreach (var pice in DataSource.DataSourceProjekatKino._namirnice)
            {
                if (pice.TipNamirnice == tipNamirnice.Pice)
                    comboBoxPice.Items.Add(pice.ImeNamirnice);
            }
        }

        private void buttonOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.PrikazRacuna));
        }

        private void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.PrikazRacuna));
        }

        private void comboBoxHrana_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBoxCijenaHrane.Text = DataSource.DataSourceProjekatKino.DajNamirnicePoTipu(tipNamirnice.Hrana)[comboBoxHrana.SelectedIndex].CijenaNamirnice.ToString();
            textBoxKolicinaHrane.Text = "1";
            kolicinaHrane = Convert.ToInt32(textBoxKolicinaHrane.Text);
            buttonDodaj1.Visibility = Visibility.Visible;
        }

        private void buttonDodaj1_Click(object sender, RoutedEventArgs e)
        {
            kolicinaHrane = Convert.ToInt32(textBoxKolicinaHrane.Text);
            DataSource.DataSourceProjekatKino._kupovine.Last().namirnice.Add(DataSource.DataSourceProjekatKino.DajNamirnicePoTipu(tipNamirnice.Hrana)[comboBoxHrana.SelectedIndex]);
            DataSource.DataSourceProjekatKino._kupovine.Last().cijenaRacuna += kolicinaHrane * DataSource.DataSourceProjekatKino.DajNamirnicePoTipu(tipNamirnice.Hrana)[comboBoxHrana.SelectedIndex].CijenaNamirnice;
        }

        private void buttonDodaj2_Click(object sender, RoutedEventArgs e)
        {
            kolicinaPica = Convert.ToInt32(textBoxKolicinaPica.Text);
            DataSource.DataSourceProjekatKino._kupovine.Last().namirnice.Add(DataSource.DataSourceProjekatKino.DajNamirnicePoTipu(tipNamirnice.Pice)[comboBoxPice.SelectedIndex]);
            DataSource.DataSourceProjekatKino._kupovine.Last().cijenaRacuna += kolicinaPica * DataSource.DataSourceProjekatKino.DajNamirnicePoTipu(tipNamirnice.Pice)[comboBoxPice.SelectedIndex].CijenaNamirnice;
        }

        private void comboBoxPice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBoxCijenaPica.Text = DataSource.DataSourceProjekatKino.DajNamirnicePoTipu(tipNamirnice.Pice)[comboBoxPice.SelectedIndex].CijenaNamirnice.ToString();
            textBoxKolicinaPica.Text = "1";
            kolicinaPica = Convert.ToInt32(textBoxKolicinaPica.Text);
            buttonDodaj2.Visibility = Visibility.Visible;
        }

        private void textBoxKolicinaHrane_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textBoxKolicinaPica_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
