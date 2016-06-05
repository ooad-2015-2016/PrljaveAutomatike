using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatKino.Models;
using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo("PrivremenaBaza")]

namespace ProjekatKino.DataSource
{
    //Klasa koja predstavlja sloj podataka 
    public class DataSourceProjekatKino
    {
        public DataSourceProjekatKino() { }

        #region Film - kreiranje testnih filmova
        internal static List<Film> _filmovi = new List<Film>()
        {
            new Film()
            {
                ime_filma = "Kum",
                trajanje = 180,
                FilmId = 1,
            },
            new Film()
            {
                ime_filma = "Kum 2",
                trajanje = 180,
                FilmId = 2,
            },
            new Film()
            {
                ime_filma = "Kum 3",
                trajanje = 180,
                FilmId = 3,
            },
            new Film()
            {
                ime_filma = "The Usual Suspects",
                trajanje = 120,
                FilmId = 4,
            },
            new Film()
            {
                ime_filma = "Kamatar",
                trajanje = 180,
                FilmId = 5,
            }
        };
        public static List<Film> DajSveFilmove()
        {
            return _filmovi;
        }
        public static Film DajFilmPoId(int FilmId)
        {
            return _filmovi.Where(k => k.FilmId.Equals(FilmId)).FirstOrDefault();
        }
        public static Film ProvjeraFilma(string ime_filma)
        {
            Film rezultat = new Film();
            foreach (var k in DajSveFilmove())
            {
                if (k.ime_filma == ime_filma && k.trajanje > 60)
                    rezultat = k;
            }
            return rezultat;
        }
        #endregion

        #region Menadzer - kreiranje testnih korisnika

        internal static List<Menadzer> _menadzeri = new List<Menadzer>()
        {
            new Menadzer()
            {
                Ime = "Medo",
                Prezime = "Brundic",
                KorisnikId = 0,
                KorisnickoIme = "manager",
                Sifra = "patlidzan",
            }
        };
        internal static List<Menadzer> DajSveMenadzere()
        {
            return _menadzeri;
        }

        #endregion

        #region Korisnik - kreiranje testnih korisnika
        internal static List<Korisnik> _korisnici = new List<Korisnik>()
        {
            new Korisnik()
            {
                Ime = "Amar",
                Prezime = "Begovic",
                KorisnikId = 1,
                KorisnickoIme = "ama_direktor",
                Sifra = "assassin",
            },
            new Korisnik()
            {
                Ime = "Nadja",
                Prezime = "Kovacevic",
                KorisnikId = 2,
                KorisnickoIme = "nadjatimelord",
                Sifra = "njena_sifra"
            },
            new Korisnik()
            {
                Ime = "Alma",
                Prezime = "Dzaferovic",
                KorisnikId = 3,
                KorisnickoIme = "alma_princess",
                Sifra = "sifrica",
            },
            new Korisnik()
            {
                Ime = "Emir",
                Prezime = "Alagic",
                KorisnikId = 4,
                KorisnickoIme = "My_Name_Is_Emir",
                Sifra = "sifra",
            }
        };
        internal static List<Korisnik> DajSveKorisnike()
        {
            return _korisnici;
        }
        internal static Korisnik DajKorisnikaPoId(int korisnikId)
        {
            return _korisnici.Where(k => k.KorisnikId.Equals(korisnikId)).FirstOrDefault();
        }
        //nece trebat vise provjera ovdje
        public static Korisnik ProvjeraKorisnika(string korisnickoIme, string sifra)
        {
            Korisnik rezultat = new Korisnik();
            foreach (var k in DajSveKorisnike())
            {
                if (k.KorisnickoIme == korisnickoIme && k.Sifra == sifra)
                    rezultat = k;
            }
            return rezultat;
        }
        #endregion


        internal static PrivremenaBaza pdb = new PrivremenaBaza();
    }
}