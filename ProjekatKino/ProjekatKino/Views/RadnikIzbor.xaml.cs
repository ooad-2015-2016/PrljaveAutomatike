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

namespace ProjekatKino
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RadnikIzbor : Page
    {
        public RadnikIzbor()
        {
            this.InitializeComponent();
            if (DataSource.DataSourceProjekatKino.DajTipTrenutnoLogovanog() == tipKorisnika.Menadzer)
                buttonPovratak.Visibility = Visibility.Visible;
        }

        private void Odabir_filma_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OdabirFilma));


        }
        private void Registruj_novog_clana_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegistrujNovogClana));


        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));

        }

        private void Povratak_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ManagerForma));
        }
    }

   
}
