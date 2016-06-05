using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum tipKorisnika { Menadzer, ObicanUposlenik };

namespace ProjekatKino.Models
{
    public class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int KorisnikId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public tipKorisnika TipKorisnika { get; set; }
        public Korisnik() { }
    }
}
