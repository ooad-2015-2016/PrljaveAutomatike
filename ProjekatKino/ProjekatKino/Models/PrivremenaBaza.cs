﻿using System;
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
        public PrivremenaBaza()
        {
            Korisnici = DataSourceProjekatKino.DajSveKorisnike();
            Filmovi = DataSourceProjekatKino.DajSveFilmove();
            //Clanovi = DataSourceProjekatKino.DajSveClanove(); treba dodat registrovane clanove u datasource
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
        public List<Film> DajSveFilmove()
        {
            return Filmovi;
        }
        public void DodajFilm(Film _film)
        {
            Filmovi.Add(_film);
        }
        public void ObrisiFilm(Film _film)
        {
            Filmovi.Remove(_film);
        }
        public List<Menadzer> DajSveMenadzere()
        {
            return Menadzeri;
        }
        public void DodajMenadzera(Menadzer _menadzer)
        {
            Menadzeri.Add(_menadzer);
        }
        public void ObrisiMenadzera(Menadzer _menadzer)
        {
            Menadzeri.Remove(_menadzer);
        }
    }
}