using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatKino.Models;
using System.Windows.Input;
using Windows.UI.Input;
using Windows.UI.Popups;
using System.ComponentModel;
using ProjekatKino.Helper;

namespace ProjekatKino.ViewModels
{
    class KorisnikViewModel
    {
        public INavigationService NavigationService { get; set; }
        public LoginViewModel Parent { get; set; }
        public ICommand OdabirFilma { get; set; }
        public ICommand RegistrujNovogClana { get; set; }

        public KorisnikViewModel(LoginViewModel parent)
        {
            NavigationService = new NavigationService();

            OdabirFilma = new RelayCommand<object>(odabirFilma, mozeLiOdabrati);
            RegistrujNovogClana = new RelayCommand<object>(registrujNovogClana, mozeLiRegistrovati);

            this.Parent = parent;
        }

        public KorisnikViewModel() //dodan samo zbog ovo dvoje ispod. zasto?! :(
        {
        }

        public bool mozeLiOdabrati(object parametar) { return true; }
        public bool mozeLiRegistrovati(object parametar) { return true; }
        public void odabirFilma(object parametar)
        {

            NavigationService.Navigate(typeof(OdabirFilma), new KorisnikViewModel()); //zbog ovog
        }
        public void registrujNovogClana(object parametar)
        {

            NavigationService.Navigate(typeof(RegistrujNovogClana), new KorisnikViewModel()); //i ovog
        }

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