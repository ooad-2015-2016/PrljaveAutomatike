using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatKino.Models;
using ProjekatKino.ViewModels;

namespace ProjekatKino.ViewModels
{
    /// <summary>
    /// mozda i nepotrebno treba razmisliti dobro
    /// </summary>
    class PrivremenaBazaViewModel
    {
        public List<Korisnik> _korisnici;
        public List<Film> _filmovi;
        public List<Menadzer> _menadzeri;
        public PrivremenaBazaViewModel() { }
        public List<Korisnik> DajSveKorisnike()
        {
            return _korisnici;
        }
        public PrivremenaBazaViewModel(PrivremenaBaza pdb)
        {
            _korisnici = new List<Korisnik>(pdb.DajSveKorisnike());
        }
        public void DodajUposlenika(Korisnik novi)
        {
            _korisnici.Add(novi);
            DataSource.DataSourceProjekatKino.pdb.Korisnici = _korisnici;
        }
        public void ObrisiUposlenika(Korisnik novi)
        {
            _korisnici.Remove(novi);
            DataSource.DataSourceProjekatKino.pdb.Korisnici = _korisnici;
        }

    }
}