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
    public sealed partial class IzmjenaClana : Page
    {
        public IzmjenaClana()
        {
            this.InitializeComponent();
            foreach(var trenutni in DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi)
            {
                comboBox.Items.Add(trenutni.Ime + " " + trenutni.Prezime);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ManagerForma));
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBlockJmbg.Visibility = Visibility.Visible;
            textBlockGrad.Visibility = Visibility.Visible;
            textBlockAdresa.Visibility = Visibility.Visible;
            textBlockEmail.Visibility = Visibility.Visible;
            textBlockTel.Visibility = Visibility.Visible;
            textBlock_Ime.Visibility = Visibility.Visible;
            textBlock_Prezime.Visibility = Visibility.Visible;

            textBox_Ime.Text = DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].Ime;
            textBox_Prezime.Text = DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].Prezime;
            textBox_Adresa.Text = DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].AdresaPrebivalista;
            textBox_Email.Text = DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].Email;
            textBox_Grad.Text = DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].GradPrebivalista;
            textBox_Jmbg.Text = DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].JMBG;
            textBox_Tel.Text = DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].BrojTelefona;

            textBox_Adresa.Visibility = Visibility.Visible;
            textBox_Email.Visibility = Visibility.Visible;
            textBox_Grad.Visibility = Visibility.Visible;
            textBox_Jmbg.Visibility = Visibility.Visible;
            textBox_Ime.Visibility = Visibility.Visible;
            textBox_Prezime.Visibility = Visibility.Visible;
            textBox_Tel.Visibility = Visibility.Visible;
        }

        private async void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if(comboBox.SelectedIndex > -1)
            {
                DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].Ime = textBox_Ime.Text;
                DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].Prezime = textBox_Prezime.Text;
                DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].AdresaPrebivalista = textBox_Adresa.Text;
                DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].Email = textBox_Email.Text;
                DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].GradPrebivalista = textBox_Grad.Text;
                DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].JMBG = textBox_Jmbg.Text;
                DataSource.DataSourceProjekatKino.pdb.RegistrovaniClanovi[comboBox.SelectedIndex].BrojTelefona = textBox_Tel.Text;

                var dialog = new Windows.UI.Popups.MessageDialog("Promijenili ste podatke člana!", "Uspješno!");
                await dialog.ShowAsync();

                this.Frame.Navigate(typeof(ManagerForma));
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Niste odabrali niti jednog člana!", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }
        }
    }
}
