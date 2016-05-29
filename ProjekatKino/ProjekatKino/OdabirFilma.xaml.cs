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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjekatKino
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OdabirFilma : Page
    {
        public OdabirFilma()
        {
            this.InitializeComponent();
        }

        private void chkStud_Checked(object sender, RoutedEventArgs e)
        {
            chkPen.IsChecked = false;
        }

        private void chkPen_Checked(object sender, RoutedEventArgs e)
        {
            chkStud.IsChecked = false;
        }

        private void dugmePotvrdi_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(nakonodabira));
        }

        private void dugmeOdustani_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }
    }
}
