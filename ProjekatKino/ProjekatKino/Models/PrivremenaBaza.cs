using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatKino.DataSource;
using ProjekatKino.Models;

namespace ProjekatKino.Models
{
    class PrivremenaBaza
    {
        public List<Korisnik> Korisnici;
        public List<Film> Filmovi;
        public PrivremenaBaza()
        {
            Korisnici = DataSourceProjekatKino.DajSveKorisnike();
            Filmovi = DataSourceProjekatKino.DajSveFilmove();
            //Clanovi = DataSourceProjekatKino.DajSveClanove(); treba dodat registrovane clanove u datasource
        }
        public List<Korisnik> DajSveKorisnike()
        {
            return Korisnici;
        }
    }
}