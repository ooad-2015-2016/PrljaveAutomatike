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
    public sealed partial class BrisanjeFilma : Page
    {
        public BrisanjeFilma()
        {
            this.InitializeComponent();
            int broj = 0;
            foreach(var trenutni in DataSource.DataSourceProjekatKino._filmovi)
            {
                comboBox.Items.Add(trenutni.ime_filma);
                broj++;
            }
        }

        private async void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if(comboBox.SelectedIndex > -1)
            {
                for(int i = 0; i < DataSource.DataSourceProjekatKino._projekcije.Count(); i++)
                {
                    if (DataSource.DataSourceProjekatKino._projekcije[i].FilmProjekcije == DataSource.DataSourceProjekatKino._filmovi[comboBox.SelectedIndex])
                    {
                        DataSource.DataSourceProjekatKino._projekcije.Remove(DataSource.DataSourceProjekatKino._projekcije[i]);
                    }
                }
                DataSource.DataSourceProjekatKino._filmovi.Remove(DataSource.DataSourceProjekatKino._filmovi[comboBox.SelectedIndex]);
                var dialog = new Windows.UI.Popups.MessageDialog("Uspješno ste obrisali film!", "Uspješno!");
                await dialog.ShowAsync();
                this.Frame.Navigate(typeof(ManagerForma));
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Niste odabrali niti jedan film!", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ManagerForma));
        }
    }
}
