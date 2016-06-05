using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatKino.DataSource;
using ProjekatKino.Models;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using ProjekatKino.Helper;
using ProjekatKino;
using System.Windows.Input;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace ProjekatKino.ViewModels
{
    class LoginViewModel
    {
        public Korisnik _korisnik { get; set; }
        public Menadzer _menadzer { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }
        public ICommand LoginUposlenik { get; set; }
        public INavigationService NavigationService { get; set; }
        public List<Korisnik> _korisnici { get; set; }
        public List<Menadzer> _menadzeri { get; set; }


        /////////////////////////////

        public LoginViewModel()
        {
            NavigationService = new NavigationService();

            _username = "";
            _password = "";

            LoginUposlenik = new RelayCommand<object>(loginUposlenik, mozeLiSePrijavitiUposlenik);

            _korisnici = DataSource.DataSourceProjekatKino.pdb.DajSveKorisnike();
            _menadzeri = DataSource.DataSourceProjekatKino.pdb.DajSveMenadzere();
        }
        public bool mozeLiSePrijavitiUposlenik(object parametar)
        {
            return true;
        }
        public Korisnik ProvjeraKorisnika(string korisnickoIme, string sifra)
        {
            Korisnik rezultat = new Korisnik();
#pragma warning disable
            foreach (Korisnik k in _korisnici)
            {
                if (k.KorisnickoIme == korisnickoIme && k.Sifra == sifra)
                    rezultat = k;
            }
            return rezultat;
        }
        public Menadzer ProvjeraMenadzera(string korisnickoIme, string sifra)
        {
            Menadzer rezultat = new Menadzer();
#pragma warning disable
            foreach (Menadzer k in _menadzeri)
            {
                if (k.KorisnickoIme == korisnickoIme && k.Sifra == sifra)
                    rezultat = k;
            }
            return rezultat;
        }
        public async void loginUposlenik(object parametar)
        {
            var UnosPassBox = parametar as PasswordBox;
            _password = UnosPassBox.Password;
            int unos = int.Parse(_username);
            //_korisnik = DataSource.DataSourceProjekatKino.ProvjeraKorisnika(_username, _password);
            _korisnik = ProvjeraKorisnika(_username, _password);
            _menadzer = ProvjeraMenadzera(_username, _password);


            if (_username != null && _password != null)
            {
                if (_menadzer != null)
                    NavigationService.Navigate(typeof(ManagerForma), new MenadzerViewModel(this));
                else if (_korisnik != null)
                    NavigationService.Navigate(typeof(RadnikIzbor), new KorisnikViewModel(this));
            }
            else
            {
                var dialog = new MessageDialog("Pogrešno korisničko ime/šifra!", "Neuspješna prijava");
                await dialog.ShowAsync();
            }
        }
    }
}