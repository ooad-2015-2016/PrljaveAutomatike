using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace ProjekatKino.ViewModels
{
    class RegistracijaViewModel
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string AdresaPrebivalista { get; set; }
        public string GradPrebivalista { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        private async void Registracija(object parameter)
        {

            if (Ime.Length == 0 || Prezime.Length == 0 || AdresaPrebivalista.Length == 0 || BrojTelefona.Length == 0 || Email.Length == 0)
            {
                var dialog = new MessageDialog("Unesite sve tražene podatke", "Neuspješna prijava");
                await dialog.ShowAsync();
            }
            else if (Ime.Length < 3 || Prezime.Length < 3 || AdresaPrebivalista.Length < 3)
            {
                var dialog = new MessageDialog("Prekratki su ime/prezime/adresa.", "Neuspješna prijava");
                await dialog.ShowAsync();
            }
            else if (BrojTelefona.Length < 6)
            {

                var dialog = new MessageDialog("Neispravan format telefona", "Neuspješna prijava");
                await dialog.ShowAsync();
            }
            else if (!Email.Contains("@") || !Email.Contains("."))
            {

                var dialog = new MessageDialog("Email nije ispravan.", "Neuspješna prijava");
                await dialog.ShowAsync();
            }
            else
            {
                var dialog = new MessageDialog("Prijava uspješno završena.Dobrodošli!", "Uspješna prijava");
                await dialog.ShowAsync();
            }
        }
    }
}