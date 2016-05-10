using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class UlogaMeniStavka
    {
        public int UlogaId { get; set; }
        public int MeniStavkaId { get; set; }
        public Uloga Uloga { get; set; }
        public MeniStavka MeniStavka { get; set; }
        public UlogaMeniStavka(Uloga uloga, MeniStavka meniStavka)
        {
            this.Uloga = uloga;
            this.MeniStavka = meniStavka;
            this.UlogaId = uloga.UlogaId;
            this.MeniStavkaId = meniStavka.MeniStavkaId;
        }
    }
}
