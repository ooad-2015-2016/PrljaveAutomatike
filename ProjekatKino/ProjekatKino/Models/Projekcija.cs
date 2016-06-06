using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class Projekcija
    {
        public Film FilmProjekcije { get; set; }
        public KinoSala Sala { get; set; }
        public int Zauzetost { get; set; }
        public int Kapacitet { get; set; }
        public DateTime VrijemeOdrzavanja { get; set; }
        public double CijenaProjekcije { get; set; }
        public bool ImaLiSlobodno
        {
            get
            {
                if (Zauzetost < Kapacitet) return true;
                return false;
            }
        }
        public Projekcija () { }
        public Projekcija (Film FilmProjekcije, KinoSala Sala, DateTime VrijemeOdrzavanja, double cijena)
        {
            this.FilmProjekcije = FilmProjekcije;
            this.Sala = Sala;
            this.Zauzetost = 0;
            this.Kapacitet = Sala.BrojMjesta;
            this.VrijemeOdrzavanja = VrijemeOdrzavanja;
            this.CijenaProjekcije = cijena;
        }
    }
}