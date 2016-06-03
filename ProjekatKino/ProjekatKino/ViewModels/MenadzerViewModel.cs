using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ProjekatKino.Helper;
using System.Windows.Input;
using ProjekatKino.Models;

namespace ProjekatKino.ViewModels
{
    class MenadzerViewModel
    {
        public INavigationService NavigationService { get; set; }
        public LoginViewModel Parent { get; set; }
        public ICommand DodajUposlenika { get; set; }
        public ICommand IzbrisiUposlenika { get; set; }
        public ICommand OdabirFilma { get; set; }
        public ICommand RegistrujNovogClana { get; set; }
        public MenadzerViewModel() { }
        public MenadzerViewModel(LoginViewModel parent)
        {
            NavigationService = new NavigationService();

            OdabirFilma = new RelayCommand<object>(odabirFilma, mozeLiOdabrati);
            RegistrujNovogClana = new RelayCommand<object>(registrujNovogClana, mozeLiRegistrovati);
            //DodajUposlenika = new RelayCommand<object>(dodajUposlenika, mozeLiOdabrati);
           // IzbrisiUposlenika = new RelayCommand<object>(izbrisiUposlenika, mozeLiRegistrovati);

            this.Parent = parent;
        }
        public bool mozeLiOdabrati(object parametar) { return true; }
        public bool mozeLiRegistrovati(object parametar) { return true; }
        public bool mozeLiDodati(object parametar) { return true; }
        public bool mozeLiIzbrisati(object parametar) { return true; }
        public void odabirFilma(object parametar)
        {
            NavigationService.Navigate(typeof(OdabirFilma), new KorisnikViewModel());
        }
        public void registrujNovogClana(object parametar)
        {

            NavigationService.Navigate(typeof(RegistrujNovogClana), new KorisnikViewModel());
        }
        public List<Korisnik> Radnici { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

            ///desavanja ako se sta mijenja
        }
    }
}
