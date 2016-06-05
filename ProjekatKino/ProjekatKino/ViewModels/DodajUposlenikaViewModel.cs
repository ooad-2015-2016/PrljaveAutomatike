using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatKino.Models;
using ProjekatKino.Helper;
using ProjekatKino.DataSource;
using System.ComponentModel;
using ProjekatKino.ViewModels;
using System.Windows.Input;

namespace ProjekatKino.ViewModels
{
    class DodajUposlenikaViewModel : INotifyPropertyChanged
    {
        public MenadzerViewModel Parent { get; set; }
        public INavigationService NavigationService { get; set; }
        public ICommand Potvrdi { get; set; }
        public ICommand Odustani { get; set; }
        public Korisnik novi = new Korisnik();
        private string ime, prezime, username, password;
        public string Ime
        {
            get { return ime; }
            set { OnPropertyChanged("Ime"); }
        }
        public string Prezime
        {
            get { return prezime; }
            set { OnPropertyChanged("Prezime"); }
        }
        public string Username
        {
            get { return username; }
            set { OnPropertyChanged("Username"); }
        }
        public string Password
        {
            get { return password; }
            set { OnPropertyChanged("Password"); }
        }
        public DodajUposlenikaViewModel()
        {
            NavigationService = new NavigationService();

            //this.Parent = p;

            Potvrdi = new RelayCommand<object>(potvrdi, mozeLiSePotvrditi);
            Odustani = new RelayCommand<object>(odustani, mozeLiSeOdustati);
        }
        public bool mozeLiSePotvrditi(object parametar)
        {
            //ovdje se moze dodati uslov ako je potrebno da se komanda ne izvrsi
            return true;
        }
        public bool mozeLiSeOdustati(object parametar)
        {
            //ovdje se moze dodati uslov ako je potrebno da se komanda ne izvrsi
            return true;
        }
        public async void potvrdi(object parametar)
        {
            if (Ime != "" && Prezime != "" && Username != "" && Password != "")
            {
                //ovdje implementirati sacuvavanje uposlenika
                int ID = 0;
                ID = DataSource.DataSourceProjekatKino.pdb.Korisnici.Count() + 1;

                novi.Ime = Ime;
                novi.Prezime = Prezime;
                novi.KorisnickoIme = Username;
                novi.Sifra = Password;
                novi.KorisnikId = ID;
                DataSourceProjekatKino.pdb.Korisnici.Add(novi);
                var dialog = new Windows.UI.Popups.MessageDialog("Uspjesno ste registrovali novog uposlenika!", "Uspjesna registracija!");
                await dialog.ShowAsync();
                //Ime = "nije dobro";
                //var dialog1 = new Windows.UI.Popups.MessageDialog(Ime + Prezime + Username + Password);
                //await dialog1.ShowAsync();
                NavigationService.Navigate(typeof(ManagerForma), new MenadzerViewModel());
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Niste ispravno unijeli podatke o uposleniku!", "Pokušajte ponovo!");
                await dialog.ShowAsync();
            }
        }
        public void odustani(object parametar)
        {
            NavigationService.Navigate(typeof(ManagerForma), new MenadzerViewModel());
        }
        public DodajUposlenikaViewModel(MenadzerViewModel menadzer_vm, string ime, string prezime, string username, string password, int korisnikID)
        {
            novi.Ime = ime;
            novi.Prezime = prezime;
            novi.KorisnickoIme = username;
            novi.Sifra = password;
            novi.KorisnikId = korisnikID;
            DataSourceProjekatKino.pdb.Korisnici.Add(novi);
        }

        //////////////////////////////////////////////////
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}