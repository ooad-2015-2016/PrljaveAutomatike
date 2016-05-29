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
    public sealed partial class NakonOdabira : Page
    {
        public NakonOdabira()
        {
            this.InitializeComponent();
        }
        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void Ponovni_odabir_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OdabirFilma));
        }
        private void Racun_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
