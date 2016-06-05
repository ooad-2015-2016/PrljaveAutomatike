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

namespace ProjekatKino.ViewModels
{
    class DodajUposlenikaViewModel : INotifyPropertyChanged
    {
        Korisnik novi = new Korisnik();
        public DodajUposlenikaViewModel(MenadzerViewModel menadzer_vm, string ime, string prezime, string username, string password, int korisnikID)
        {
            novi.Ime = ime;
            novi.Prezime = prezime;
            novi.KorisnickoIme = username;
            novi.Sifra = password;
            novi.KorisnikId = korisnikID;
            DataSourceProjekatKino.pdb.DajSveKorisnike().Add(novi);
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