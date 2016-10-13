using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krankmeldung 
{
    class Dokument : INotifyPropertyChanged
    {
        string pfad;
        string beschreibung;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Beschreibung
        {
            get { return beschreibung; }
            set { 
                beschreibung = value;
                NotifyPropertyChanged("Beschreibung");
            }
        }

        public string Pfad
        {
            get { return pfad; }
            set {
                pfad = value;
                NotifyPropertyChanged("Pfad");
            }
        }

        public Dokument(string _beschreibung)
        {
            this.beschreibung = _beschreibung;
        }

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }



    }
}
