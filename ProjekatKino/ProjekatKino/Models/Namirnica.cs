using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum tipNamirnice { Hrana, Pice };

namespace ProjekatKino.Models
{
    public class Namirnica
    {
        public tipNamirnice TipNamirnice { get; set; }
        public string ImeNamirnice { get; set; }
        public double CijenaNamirnice { get; set; }
        public Namirnica() { }
    }
}
