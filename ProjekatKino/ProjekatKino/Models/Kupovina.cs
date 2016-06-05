using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class Kupovina
    {
        public Film filmKupovine { get; set; }
        public Models.RegistrovaniClan posjetitelj { get; set; }
        public Models.Projekcija projekcija { get; set; }
        public List<Models.Namirnica> namirnice { get; set; }
        public double cijenaRacuna { get; set; }
        public DateTime datumKupovine { get; set; }
        public tipPosjetitelja TipPosjetitelja { get; set; }
        public string NacinPlacanja { get; set; }
        public Kupovina() { }
    }
}
