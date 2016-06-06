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
    public sealed partial class IzbrisiNamirnice : Page
    {
        bool izabrano = false;
        public IzbrisiNamirnice()
        {
            this.InitializeComponent();
            foreach(var trenutna in DataSource.DataSourceProjekatKino._namirnice)
            {
                comboBox.Items.Add(trenutna.ImeNamirnice.ToString());
            }
        }

        private async void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if(izabrano)
            {
                DataSource.DataSourceProjekatKino._namirnice.Remove(DataSource.DataSourceProjekatKino._namirnice[comboBox.SelectedIndex]);
                this.Frame.Navigate(typeof(ManagerForma));
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Niste odabrali niti jednu namirnicu!", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ManagerForma));
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            izabrano = true;
        }
    }
}
