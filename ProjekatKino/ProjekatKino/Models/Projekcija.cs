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
        public int CijenaProjekcije { get; set; }
        public bool ImaLiSlobodno
        {
            get
            {
                if (Zauzetost < Kapacitet) return true;
                return false;
            }
        }
    }
}