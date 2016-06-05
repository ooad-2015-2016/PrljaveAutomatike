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
        bool odabranoPlacanje = false;
        public PrikazRacuna()
        {
            this.InitializeComponent();
            //Ovdje u textbox dodajemo koliko košta sve ukupno, karte i hrana
            //Npr. 5 KM
            //Da bi radilo treba imati odrađenu klasu projekciju i jedan njen primjer u DataSource
            //Treba klasa Namirnica za neki primjer i klasa Racun - sve su public class
            textBoxUkupnaCijena.Text = DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1].cijenaRacuna.ToString() + " KM";
            comboBoxPlacanje.Items.Add("Gotovinsko plaćanje");
            comboBoxPlacanje.Items.Add("Placanje karticom");
        }

        private async void buttonZakljuciRacun_Click(object sender, RoutedEventArgs e)
        {
            //Ovdje dodati sta god treba za zakljucivanje racuna
            if (!odabranoPlacanje)
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Niste odabrali način plaćanja!", "Pogreška!");
                await dialog.ShowAsync();
            }
            else
            {
                //OVDJE DODATI PLACANJE AKO JE IZABRANA KARTICA, ONO SA RFID
                //kartica je izabrana ako je ispunjeno if(DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1].NacinPlacanja == "Plaćanje karticom")
                //OVDJE JE TEXT BOX KOJI SLUZI ZA KUPLJENJE KODA SA RFID
                if (DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1].NacinPlacanja == "Placanje karticom")
                {
                    textBoxRfid.Visibility = Visibility.Visible;
                    //ovdje treba staviti da je textBoxRfid.Text = procitanom stringu sa rfid
                }
                else
                {
                    var dialog = new Windows.UI.Popups.MessageDialog("Uspješno izrađen račun!", "Uspješna prodaja!");
                    await dialog.ShowAsync();
                }
                //svakako prije kraja i uspjesne prodaje se mora povecati broj zauzetih mjesta
                for(int i = 0; i < DataSource.DataSourceProjekatKino._projekcije.Count(); i++)
                {
                    if(DataSource.DataSourceProjekatKino._projekcije[i] == DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1].projekcija)
                    {
                        DataSource.DataSourceProjekatKino._projekcije[i].Zauzetost++;
                    }
                }
                this.Frame.Navigate(typeof(RadnikIzbor));
            }
        }

        private void buttonPonistiRacun_Click(object sender, RoutedEventArgs e)
        {
            //Ovdje se vracamo nazad na odabir filma
            DataSource.DataSourceProjekatKino._kupovine.Remove(DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1]);
            this.Frame.Navigate(typeof(OdabirFilma));
        }

        private void buttonDodajHranuIPice_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.OdabirNamirnica));
            //Ovdje preusmjeravamo na ponudu hrane i pica
            //this.Frame.Navigate(typeof(Views.OdabirNamirnica));
        }

        private void comboBoxPlacanje_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            odabranoPlacanje = true;
            DataSource.DataSourceProjekatKino._kupovine[DataSource.DataSourceProjekatKino.trenutniIndeks()-1].NacinPlacanja = comboBoxPlacanje.SelectedItem.ToString();
        }
    }
}
