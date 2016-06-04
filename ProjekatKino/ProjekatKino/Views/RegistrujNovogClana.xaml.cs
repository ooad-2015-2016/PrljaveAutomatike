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
    public sealed partial class RegistrujNovogClana : Page
    {
        public RegistrujNovogClana()
        {
            this.InitializeComponent();
        }

        private void Sljedeca_Click(object sender, RoutedEventArgs e)
        {
            //sakrij
            textBoxIme.Visibility = Visibility.Collapsed;
            textBoxPrezime.Visibility = Visibility.Collapsed;
            datePickerDatum.Visibility = Visibility.Collapsed;
            textBlockDatum.Visibility = Visibility.Collapsed;
            textBoxJMBG.Visibility = Visibility.Collapsed;
            textBoxAdresa.Visibility = Visibility.Collapsed;
            textBoxGrad.Visibility = Visibility.Collapsed;
            textBoxTelefon.Visibility = Visibility.Collapsed;
            //pokazi
            checkBoxPenzioner.Visibility = Visibility.Visible;
            checkBoxStudent.Visibility = Visibility.Visible;
            textBoxEmail.Visibility = Visibility.Visible;
            textBoxFakultet.Visibility = Visibility.Visible;
            textBoxIndeks.Visibility = Visibility.Visible;
            comboBoxSpol.Visibility = Visibility.Visible;

        }

        private void Ponisti_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RadnikIzbor));
        }


    }
}
