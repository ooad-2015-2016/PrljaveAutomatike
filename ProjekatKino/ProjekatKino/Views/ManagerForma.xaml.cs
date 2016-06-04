﻿using System;
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
    public sealed partial class ManagerForma : Page
    {
        public ManagerForma()
        {
            this.InitializeComponent();
        }

        private void Osnovni_Izbornik_Click(System.Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RadnikIzbor));

        }

        private void IzmjenaProjekcije_Click(System.Object sender, RoutedEventArgs e)
        {

        }

        private void Dodavanje_filma_Click(System.Object sender, RoutedEventArgs e)
        {

        }

        private void Izmjena_clana_Click(System.Object sender, RoutedEventArgs e)
        {

        }

        private void buttonIzbrisiUposlenika_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.IzbrisiUposlenika));
        }

        private void buttonDodajUposlenika_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.DodajUposlenika));
        }
    }
}
