using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krankenmeldung
{
    public class Lehrer : INotifyPropertyChanged
    {
        string kuerzel;
        string name;
        string vorname;
        string benutzername;
        string passwort;
        bool isKlassenlehrer = false;

        public event PropertyChangedEventHandler PropertyChanged;


        public string Kuerzel
        {
            get { return kuerzel; }
            set
            {
                kuerzel = value;
                NotifyPropertyChanged("Kuerzel");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string Vorname
        {
            get { return vorname; }
            set
            {
                vorname = value;
                NotifyPropertyChanged("Vorname");
            }
        }

        public string Benutzername
        {
            get { return benutzername; }
            set
            {
                benutzername = value;
                NotifyPropertyChanged("Benutzername");
            }
        }

        public string Passwort
        {
            get { return passwort; }
            set
            {
                passwort = value;
                NotifyPropertyChanged("Passwort");
            }
        }

        public bool IsKlassenlehrer
        {
            get { return isKlassenlehrer; }
            set
            {
                isKlassenlehrer = value;
                NotifyPropertyChanged("IsKlassenlehrer");
            }
        }

        public Lehrer(string _kuerzel, string _name, string _vorname, string _benutzername, string _passwort)
        {
            this.kuerzel = _kuerzel;
            this.name = _name;
            this.vorname = _vorname;
            this.benutzername = _benutzername;
            this.passwort = _passwort;
        }

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
