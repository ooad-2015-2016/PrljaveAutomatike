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
    public sealed partial class PrikazRacuna : Page
    {
        public PrikazRacuna()
        {
            this.InitializeComponent();
            //Ovdje u textbox dodajemo koliko košta sve ukupno, karte i hrana
            //Npr. 5 KM
            //Da bi radilo treba imati odrađenu klasu projekciju i jedan njen primjer u DataSource
            //Treba klasa Namirnica za neki primjer i klasa Racun - sve su public class
            textBoxUkupnaCijena.Text = "5" + " KM";
        }

        private async void buttonZakljuciRacun_Click(object sender, RoutedEventArgs e)
        {
            //Ovdje dodati sta god treba za zakljucivanje racuna
            var dialog = new Windows.UI.Popups.MessageDialog("Uspješno izrađen račun!", "Uspješna prodaja!");
            await dialog.ShowAsync();
            this.Frame.Navigate(typeof(RadnikIzbor));
        }

        private void buttonPonistiRacun_Click(object sender, RoutedEventArgs e)
        {
            //Ovdje se vracamo nazad na odabir filma
            this.Frame.Navigate(typeof(OdabirFilma));
        }

        private void buttonDodajHranuIPice_Click(object sender, RoutedEventArgs e)
        {
            //Ovdje preusmjeravamo na ponudu hrane i pica
            //this.Frame.Navigate(typeof(Views.OdabirNamirnica));
        }
    }
}
