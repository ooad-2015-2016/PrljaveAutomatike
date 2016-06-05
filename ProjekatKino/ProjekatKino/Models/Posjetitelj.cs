using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum tipPosjetitelja { Neuclanjen, Uclanjen};

namespace ProjekatKino.Models
{
    public class Posjetitelj
    {
        public tipPosjetitelja TipPosjetitelja { get; set; }
    }
}
