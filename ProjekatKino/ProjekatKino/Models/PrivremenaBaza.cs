using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatKino.DataSource;
using ProjekatKino.Models;

namespace ProjekatKino.Models
{
    class PrivremenaBaza
    {
        public List<Korisnik> Korisnici;
        public List<Film> Filmovi;
        public List<Menadzer> Menadzeri;
        public List<RegistrovaniClan> RegistrovaniClanovi;
        public PrivremenaBaza()
        {
            Korisnici = DataSourceProjekatKino.DajSveKorisnike();
            Menadzeri = DataSourceProjekatKino.DajSveMenadzere();
            Filmovi = DataSourceProjekatKino.DajSveFilmove();
            RegistrovaniClanovi = DataSourceProjekatKino.DajSveRegistrovaneClanove(); //treba dodat registrovane clanove u datasource
        }
        public List<Korisnik> DajSveKorisnike()
        {
            return Korisnici;
        }
        public void DodajKorisnika(Korisnik _korisnik)
        {
            Korisnici.Add(_korisnik);
        }
        public void ObrisiKorisnika(Korisnik _korisnik)
        {
            Korisnici.Remove(_korisnik);
        }
        public Korisnik ProvjeraKorisnika(string korisnickoIme, string sifra)
        {
            Korisnik rezultat = new Korisnik();
            foreach (var k in Korisnici)
            {
                if (k.KorisnickoIme == korisnickoIme && k.Sifra == sifra)
                    rezultat = k;
            }
            return rezultat;
        }
        public Korisnik ProvjeraKorisnikaPoImenu(string ime, string prezime, string username)
        {
            Korisnik rezultat = new Korisnik();
            foreach (var k in Korisnici)
            {
                if (k.Ime == ime && k.Prezime == prezime && k.KorisnickoIme == username)
                    rezultat = k;
            }
            return rezultat;
        }
        public List<Film> DajSveFilmove()
        {
            return Filmovi;
        }
        public List<Menadzer> DajSveMenadzere()
        {
            return Menadzeri;
        }
        public Menadzer ProvjeraMenadzera(string korisnickoIme, string sifra)
        {
            Menadzer rezultat = new Menadzer();
            foreach (var k in Menadzeri)
            {
                if (k.KorisnickoIme == korisnickoIme && k.Sifra == sifra)
                    rezultat = k;
            }
            return rezultat;
        }
        public List<RegistrovaniClan> DajSveRegistrovaneClanove()
        {
            return RegistrovaniClanovi;
        }
        public RegistrovaniClan ProvjeraRegistrovanihClanova(string ime, string prezime)
        {
            RegistrovaniClan rezultat = new RegistrovaniClan();
            foreach (var k in RegistrovaniClanovi)
            {
                if (k.Ime == ime && k.Prezime == prezime)
                    rezultat = k;
            }
            return rezultat;
        }
    }
}