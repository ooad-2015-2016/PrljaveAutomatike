using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatKino.DataSource;
using ProjekatKino.Models;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using ProjekatKino.Helper;
using ProjekatKino.ProjekatKino_XamlTypeInfo;
using ProjekatKino;
using System.Windows.Input;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace ProjekatKino.ViewModels
{
    class LoginViewModel
    {
        public Korisnik _korisnik { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }
        public ICommand LoginUposlenik { get; set; }
        public INavigationService NavigationServis { get; set; }

    }
}
