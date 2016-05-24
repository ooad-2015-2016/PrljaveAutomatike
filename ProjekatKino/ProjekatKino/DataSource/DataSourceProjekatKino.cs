using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.DataSource
{
    //Klasa koja predstavlja sloj podataka 
    public class DataSourceMenuMD
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
                KorisnikId = 1,
                KorisnickoIme = "ama_direktor",
                Sifra = "assassin",
            },
            new Models.Korisnik()
            {
                KorisnikId = 2,
                KorisnickoIme = "nadjatimelord",
                Sifra = "njena_sifra"
            },
            new Models.Korisnik()
            {
                KorisnikId = 3,
                KorisnickoIme = "alma_princess",
                Sifra = "sifrica",
            },
            new Models.Korisnik()
            {
                KorisnikId = 4,
                KorisnickoIme = "My_Name_Is_Emir",
                Sifra = "zajebanasifra",
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

        #region Uloga - kreiranje testnih uloga
        private static List<Models.Uloga> _uloge = new List<Models.Uloga>()
        {
            new Models.Uloga()
            {
                UlogaId = 1,
                Naziv = "Administrator",
            },
            new Models.Uloga()
            {
                UlogaId = 2,
                Naziv = "Registrovani korisnik",
            }
        };
        public static IList<Models.Uloga> DajSveUloge()
        {
            return _uloge;
        }
        public static Models.Uloga DajUloguPoId(int ulogaId)
        {
            return _uloge.Where(k => k.UlogaId.Equals(ulogaId)).FirstOrDefault();
        }
        #endregion

        #region MeniStavka - kreiranje novih meni stavki
        private static List<Models.MeniStavka> _meniStavke = new List<Models.MeniStavka>()
        {
            new Models.MeniStavka()
            {
                MeniStavkaId =1,
                Naziv ="Primjer forme 1",
                Kod ="F1",
                //Podstranica = typeof(PrimjerStranice1)
            },
            new Models.MeniStavka()
            {
                MeniStavkaId =2,
                Naziv ="Primjer forme 2",
                Kod ="F2",
                //Podstranica = typeof(PrimjerStranice2)
            },
            new Models.MeniStavka()
            {
                MeniStavkaId =3,
                Naziv ="Primjer forme 3",
                Kod ="F3",
                //Podstranica = typeof(PrimjerStranice3)
            },
            new Models.MeniStavka()
            {
                MeniStavkaId =4,
                Naziv ="Primjer forme 4",
                Kod ="F4",
                //Podstranica = typeof(PrimjerStranice4)
            },
        };
        public static IList<Models.MeniStavka> DajSveMeniStavke()
        {
            return _meniStavke;
        }
        public static Models.MeniStavka DajMeniStavkuPoId(int meniStavkaId)
        {
            return _meniStavke.Where(k => k.MeniStavkaId.Equals(meniStavkaId)).FirstOrDefault();
        }
        #endregion

        #region Inicijalna postavka uloga i stavki
        public DataSourceMenuMD()
        {
            Models.Korisnik k1 = DajKorisnikaPoId(1);
            Models.Korisnik k2 = DajKorisnikaPoId(2);
            Models.Uloga u1 = DajUloguPoId(1);
            Models.Uloga u2 = DajUloguPoId(2);
            Models.MeniStavka ms1 = DajMeniStavkuPoId(1);
            Models.MeniStavka ms2 = DajMeniStavkuPoId(2);
            Models.MeniStavka ms3 = DajMeniStavkuPoId(3);
            Models.MeniStavka ms4 = DajMeniStavkuPoId(4);
            //Dodavanje stavki ulozi i uloge korisniku 1 
            u1.DodajMeniStavkuUlozi(ms1);
            u1.DodajMeniStavkuUlozi(ms2);
            u1.DodajMeniStavkuUlozi(ms3);
            k1.DodajUloguKorisnika(u1);
            //Dodavanje stavki ulozi i uloge korisniku 2
            u2.DodajMeniStavkuUlozi(ms4);
            k2.DodajUloguKorisnika(u2);
        }
        #endregion
    }
}
