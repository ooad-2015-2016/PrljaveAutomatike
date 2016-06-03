using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.DataSource
{
    //Klasa koja predstavlja sloj podataka 
    public class DataSourceProjekatKino
    {
        #region Film - kreiranje testnih filmova
        private static List<Models.Film> _filmovi = new List<Models.Film>()
        {
            new Models.Film()
            {
                ime_filma = "Kum",
                trajanje = 180,
                FilmId = 1,
            },
            new Models.Film()
            {
                ime_filma = "Kum 2",
                trajanje = 180,
                FilmId = 2,
            },
            new Models.Film()
            {
                ime_filma = "Kum 3",
                trajanje = 180,
                FilmId = 3,
            },
            new Models.Film()
            {
                ime_filma = "The Usual Suspects",
                trajanje = 120,
                FilmId = 4,
            },
            new Models.Film()
            {
                ime_filma = "Kamatar",
                trajanje = 180,
                FilmId = 5,
            }
        };
        public static IList<Models.Film> DajSveFilmove()
        {
            return _filmovi;
        }
        public static Models.Film DajFilmPoId(int FilmId)
        {
            return _filmovi.Where(k => k.FilmId.Equals(FilmId)).FirstOrDefault();
        }
        public static Models.Film ProvjeraFilma(string ime_filma)
        {
            Models.Film rezultat = new Models.Film();
            foreach (var k in DajSveFilmove())
            {
                if (k.ime_filma == ime_filma && k.trajanje>60)
                    rezultat = k;
            }
            return rezultat;
        }
        #endregion

        #region Korisnik - kreiranje testnih korisnika
        private static List<Models.Korisnik> _korisnici = new List<Models.Korisnik>()
        {
            new Models.Korisnik()
            {
                Ime = "Amar",
                Prezime = "Begovic",
                KorisnikId = 1,
                KorisnickoIme = "ama_direktor",
                Sifra = "assassin",
            },
            new Models.Korisnik()
            {
                Ime = "Nadja",
                Prezime = "Kovacevic",
                KorisnikId = 2,
                KorisnickoIme = "nadjatimelord",
                Sifra = "njena_sifra"
            },
            new Models.Korisnik()
            {
                Ime = "Alma",
                Prezime = "Dzaferovic",
                KorisnikId = 3,
                KorisnickoIme = "alma_princess",
                Sifra = "sifrica",
            },
            new Models.Korisnik()
            {
                Ime = "Emir",
                Prezime = "Alagic",
                KorisnikId = 4,
                KorisnickoIme = "My_Name_Is_Emir",
                Sifra = "zajebanasifra",
            },
            new Models.Korisnik()
            {
                Ime = "Medo",
                Prezime = "Brundic",
                KorisnikId = 5,
                KorisnickoIme = "manager",
                Sifra = "patlidzan",
            }
        };
        public static IList<Models.Korisnik> DajSveKorisnike()
        {
            return _korisnici;
        }
        public static Models.Korisnik DajKorisnikaPoId(int korisnikId)
        {
            return _korisnici.Where(k => k.KorisnikId.Equals(korisnikId)).FirstOrDefault();
        }
        public static Models.Korisnik ProvjeraKorisnika(string korisnickoIme, string sifra)
        {
            Models.Korisnik rezultat = new Models.Korisnik();
            foreach (var k in DajSveKorisnike())
            {
                if (k.KorisnickoIme == korisnickoIme && k.Sifra == sifra)
                    rezultat = k;
            }
            return rezultat;
        }
        #endregion
    }
}
