using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class ProgramskiSadrzaj
    {
        public virtual ICollection<Film> filmovi { get; set; }

    }
}
