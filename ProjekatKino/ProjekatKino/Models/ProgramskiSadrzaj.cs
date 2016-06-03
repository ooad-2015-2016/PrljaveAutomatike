using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class ProgramskiSadrzaj
    {
        int brojfilmova;
        List<Film> filmovi;

        public ProgramskiSadrzaj() { }
        public void DodajFilm(Film film)
        {

            this.filmovi.Add(film);
        }
        public void IzbaciFilm(Film film)
        {
            this.filmovi.Remove(film);
        }

        public List<Film> KreirajProgramskiSadrzaj(List<Film> lista)
        {
            return lista;
        }

    }

}
