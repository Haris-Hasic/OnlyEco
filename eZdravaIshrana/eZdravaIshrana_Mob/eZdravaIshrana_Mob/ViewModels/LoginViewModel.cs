using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace eZdravaIshrana_Mob.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        //public LoginViewModel() {
        //    LoginComand = new Command(() => { });
        //}
        string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }
        string _lozinka = string.Empty;
        public string Lozinka
        {
            get { return _lozinka; }
            set { SetProperty(ref _lozinka, value); }
        }
        public ICommand LoginComand { get; set; }
    }
}
