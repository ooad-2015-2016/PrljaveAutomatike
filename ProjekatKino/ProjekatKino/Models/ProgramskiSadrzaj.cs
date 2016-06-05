using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class ProgramskiSadrzaj
    {
        private List<Film> filmovi;

        public ProgramskiSadrzaj() { }
        public void DodajFilm(Film film)
        {
            filmovi.Add(film);
        }
        public void IzbaciFilm(Film film)
        {
            filmovi.Remove(film);
        }
        public ProgramskiSadrzaj(List<Film> lista)
        {
            int i = 0;
            foreach (Film film in lista)
            {
                DodajFilm(lista[i]);
                i++;
            }
        }
    }
}