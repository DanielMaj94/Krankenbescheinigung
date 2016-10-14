using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krankenmeldung
{
    public class Schueler : INotifyPropertyChanged
    {
        string name;
        string vorname;
        int alter;
        string strasse;
        string plz;
        string ort;
        string firma;
        string email;
        string klasse;
        string status = "Anwesend";

        public event PropertyChangedEventHandler PropertyChanged;


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

        public int Alter
        {
            get { return alter; }
            set
            {
                alter = value;
                NotifyPropertyChanged("Alter");
            }
        }

        public string Strasse
        {
            get { return strasse; }
            set
            {
                strasse = value;
                NotifyPropertyChanged("Strasse");
            }
        }

        public string Plz
        {
            get { return plz; }
            set
            {
                plz = value;
                NotifyPropertyChanged("Plz");
            }
        }

        public string Ort
        {
            get { return ort; }
            set
            {
                ort = value;
                NotifyPropertyChanged("Ort");
            }
        }

        public string Firma
        {
            get { return firma; }
            set
            {
                firma = value;
                NotifyPropertyChanged("Firma");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                NotifyPropertyChanged("Email");
            }
        }

        public string Klasse
        {
            get { return klasse; }
            set
            {
                klasse = value;
                NotifyPropertyChanged("klasse");
            }
        }

        public string Status
        {
            get { return status; }
            set
            {
                status = value;
                NotifyPropertyChanged("Status");
            }
        }

        public Schueler(string _name, string _vorname, int _alter, string _strasse, string _plz, string _ort, string _firma, string _email, string _klasse/*, string _status*/)
        {
            this.name = _name;
            this.vorname = _vorname;
            this.alter = _alter;
            this.strasse = _strasse;
            this.plz = _plz;
            this.ort = _ort;
            this.firma = _firma;
            this.email = _email;
            this.klasse = _klasse;
            //this.status = _status;
        }

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
