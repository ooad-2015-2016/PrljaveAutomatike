using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class Projekcija
    {
        public KinoSala sala { get; set; }
        public int zauzetost { get; set; }
        public int kapacitet { get; set; }
        public DateTime VrijemeOdrzavanja { get; set; }
        public int cijenaProjekcije { get; set; }
        public bool ImaLiSlobodno
        {
            get
            {
                if (zauzetost < kapacitet) return true;
                return false;
            }
        }
    }
}