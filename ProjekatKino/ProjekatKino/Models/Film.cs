using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string ime_filma { get; set; }
        public int trajanje { get; set; }
        public Film() { }
        public Film(int FilmId, string ime_filma, int trajanje)
        {
            this.FilmId = FilmId;
            this.ime_filma = ime_filma;
            this.trajanje = trajanje;
        }
    }
}
