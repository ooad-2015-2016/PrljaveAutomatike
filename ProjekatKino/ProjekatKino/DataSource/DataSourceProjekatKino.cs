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

        #region Menadzer - kreiranje testnih menadzera

        internal static List<Menadzer> _menadzeri = new List<Menadzer>()
        {
            new Menadzer()
            {
                Ime = "Medo",
                Prezime = "Brundic",
                KorisnikId = 86,
                KorisnickoIme = "manager",
                Sifra = "patlidzan",
            },
            new Menadzer()
            {
                Ime = "Hamo",
                Prezime = "Pipa",
                KorisnikId = 87,
                KorisnickoIme = "manager2",
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

        #region Namirnica - kreiranje testnih namirnica
        internal static List<Namirnica> _namirnice = new List<Namirnica>()
        {
            new Namirnica()
            {
                TipNamirnice = tipNamirnice.Hrana,
                ImeNamirnice = "Čipi čips",
                CijenaNamirnice = 2.5,
            },
            new Namirnica()
            {
                TipNamirnice = tipNamirnice.Hrana,
                ImeNamirnice = "Kokice",
                CijenaNamirnice = 1.5,
            },
            new Namirnica()
            {
                TipNamirnice = tipNamirnice.Pice,
                ImeNamirnice = "Coca Cola",
                CijenaNamirnice = 1.5,
            },
            new Namirnica()
            {
                TipNamirnice = tipNamirnice.Pice,
                ImeNamirnice = "Fanta",
                CijenaNamirnice = 1.5,
            }

        };
        internal static List<Namirnica> DajSveNamirnice()
        {
            return _namirnice;
        }
        internal static List<Namirnica> DajNamirnicePoTipu(tipNamirnice Tip)
        {
            List<Namirnica> rezultat = new List<Namirnica>();
            foreach (var trenutna in DajSveNamirnice())
            {
                if (trenutna.TipNamirnice == Tip)
                    rezultat.Add(trenutna);
            }
            return rezultat;
        }
        #endregion

        #region Kino Sale - kreiranje testnih sala
        internal static List<KinoSala> _sale = new List<KinoSala>()
        {
            new KinoSala()
            {
                BrojMjesta = 150,
                NazivSale = "S1"
            },
            new KinoSala()
            {
                BrojMjesta = 100,
                NazivSale = "S2"
            }
        };
        public static List<KinoSala> DajSveSale()
        {
            return _sale;
        }
        #endregion

        #region Kupovina - formiranje kupovina
        internal static List<Kupovina> _kupovine = new List<Kupovina>()
        {
        };
        internal static List<Kupovina> DajSveKupovine()
        {
            return _kupovine;
        }
        internal static List<Kupovina> DajKupovineRegistrovanihClanova()
        {
            List<Kupovina> rezultat = new List<Kupovina>();
            foreach (var trenutna in DajSveKupovine())
            {
                if (trenutna.TipPosjetitelja == tipPosjetitelja.Uclanjen)
                    rezultat.Add(trenutna);
            }
            return rezultat;
        }
        internal static double UkupnoZaradjenoNaDan(DateTime vrijeme)
        {
            double Zaradjeno = 0;
            foreach (var trenutna in DajSveKupovine())
            {
                if (trenutna.datumKupovine == vrijeme)
                    Zaradjeno += trenutna.cijenaRacuna;
            }
            return Zaradjeno;
        }
        internal static int trenutniIndeks()
        {
            return _kupovine.Count();
        }
        #endregion

        #region Projekcije - kreiranje testnih projekcija
        internal static List<Projekcija> _projekcije = new List<Projekcija>()
        {
            new Projekcija()
            {
                CijenaProjekcije = 7,
                Sala = _sale[1],
                Zauzetost = 0,
                Kapacitet = _sale[0].BrojMjesta,
                VrijemeOdrzavanja = DateTime.Today,
                FilmProjekcije = _filmovi[1]
            },
            new Projekcija()
            {
                CijenaProjekcije = 9,
                Sala = _sale[0],
                Zauzetost = 0,
                Kapacitet = _sale[0].BrojMjesta,
                VrijemeOdrzavanja = DateTime.Today,
                FilmProjekcije = _filmovi[0]
            },
            new Projekcija()
            {
                CijenaProjekcije = 8,
                Sala = _sale[1],
                Zauzetost = 0,
                Kapacitet = _sale[0].BrojMjesta,
                VrijemeOdrzavanja = DateTime.Today,
                FilmProjekcije = _filmovi[2]
            },
            new Projekcija()
            {
                CijenaProjekcije = 5,
                Sala = _sale[0],
                Zauzetost = 0,
                Kapacitet = _sale[0].BrojMjesta,
                VrijemeOdrzavanja = DateTime.Today,
                FilmProjekcije = _filmovi[3]
            },
            new Projekcija()
            {
                CijenaProjekcije = 5,
                Sala = _sale[1],
                Zauzetost = 0,
                Kapacitet = _sale[0].BrojMjesta,
                VrijemeOdrzavanja = DateTime.Today,
                FilmProjekcije = _filmovi[4]
            }
        };
        internal static List<Projekcija> DajSveProjekcije()
        {
            return _projekcije;
        }
        #endregion
        #region Posjetitelji - kreiranje testnih posjetitelja
        internal static List<RegistrovaniClan> _registrovaniClanovi = new List<RegistrovaniClan>()
        {
            new RegistrovaniClan("Meho", "Mehic", "Adresa Adresa", "Sarajevo", "mail", 12, "1234567891234", "061021931"),
        };
        internal static List<RegistrovaniClan> DajSveRegistrovaneClanove()
        {
            return _registrovaniClanovi;
        }
        internal static RegistrovaniClan DajClanaSaJMBG(string JMBG)
        {
            foreach (var trenutni in DajSveRegistrovaneClanove())
            {
                if (trenutni.JMBG == JMBG)
                    return trenutni;
            }
            return null;
        }
        #endregion
        internal static PrivremenaBaza pdb = new PrivremenaBaza();
    }
}
