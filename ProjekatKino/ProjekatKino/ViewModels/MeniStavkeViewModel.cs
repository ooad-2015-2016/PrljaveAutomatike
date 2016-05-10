using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.ViewModels
{
    public class MeniStavkeViewModel
    {
        private int _meniStavkaId;
        public int MeniStavkaId
        {
            get
            {
                return _meniStavkaId;
            }
        }
        public string Naziv { get; set; }
        public Type Podstranica { get; set; }
        public MeniStavkeViewModel() { }
    }

    ///nije nesto uredu sa _meniStavkaId
    
    //metoda koja mapira MeniStavke iz Modela u ViewModel koji se koristi na view-u
    /*public static MeniStavkeViewModel SaMeniStavke(Models.MeniStavka menistavka)
    {
        var viewModel = new MeniStavkeViewModel();
        viewModel._meniStavkaId = menistavka.MeniStavkaId;
        viewModel.Naziv = menistavka.Naziv;
        viewModel.Podstranica = menistavka.Podstranica;
        return viewModel;
    }*/
}
