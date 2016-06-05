using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class RegistrovaniClan : Posjetitelj
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string AdresaPrebivalista { get; set; }
        public string GradPrebivalista { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string JMBG { get; set; }


        public int ID { get; set; }
        public string Jmbg { get; set; }
        public string Fakultet { get; set; }
        public string Indeks { get; set; }

        public RegistrovaniClan() { }
        public RegistrovaniClan(string Ime, string Prezime, string Adresa, string Grad, string Email, int ID, string JMBG, string BrojTelefona)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.AdresaPrebivalista = Adresa;
            this.GradPrebivalista = Grad;
            this.Email = Email;
            this.JMBG = JMBG;
            this.BrojTelefona = BrojTelefona;
        }
    }
}
