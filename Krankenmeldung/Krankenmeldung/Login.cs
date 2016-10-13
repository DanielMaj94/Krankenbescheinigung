using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krankmeldung
{
    class Login : INotifyPropertyChanged
    {
        string benutzername;
        string passwort;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Benutzername
        {
            get { return benutzername; }
            set {
                benutzername = value;
                NotifyPropertyChanged("Benutzername");
            }
        }
        
        public string Passwort
        {
            get { return passwort; }
            set {
                passwort = value;
                NotifyPropertyChanged("Passwort");
            }
        }

        public Login()
        {

        }

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

    }
}
