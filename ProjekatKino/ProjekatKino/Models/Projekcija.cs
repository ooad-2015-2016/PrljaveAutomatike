using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    class Projekcija
    {
        KinoSala Sala { get; set; }
        int zauzetost { get; set; }
        DateTime VrijemeOdrzavanja { get; set; }
        bool ImaLiSlobodno { get; set; }


    }
}