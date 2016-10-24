using Krankmeldung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krankenmeldung
{
    public class KrankerSchueler : INotifyPropertyChanged
    {
        int id;
        Schueler schueler;
        string datum;
        string uhrzeitVon;
        string uhrzeitBis;
        string status = "Anwesend";

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged("Id");
            }
        }

        public Schueler Schueler
        {
            get { return schueler; }
            set
            {
                schueler = value;
                NotifyPropertyChanged("schueler");
            }
        }

        public string UhrzeitBis
        {
            get { return uhrzeitBis; }
            set
            {
                uhrzeitBis = value;
                NotifyPropertyChanged("uhrzeitBis");
            }
        }

        public string Uhrzeit
        {
            get { return uhrzeitVon; }
            set
            {
                uhrzeitVon = value;
                NotifyPropertyChanged("uhrzeitVon");
            }
        }

        public string Datum
        {
            get { return datum; }
            set
            {
                datum = value;
                NotifyPropertyChanged("datum");
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

        public KrankerSchueler(int _id, Schueler _schueler, string _datum, string _uhrzeitVon, string _uhrzeitBis, string _status)
        {
            this.id = _id;
            this.schueler = _schueler;
            this.datum = _datum;
            this.uhrzeitVon = _uhrzeitVon;
            this.uhrzeitBis = _uhrzeitBis;
            this.status = _status;
        }

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
