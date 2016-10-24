using Krankenmeldung;
using Krankmeldung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Krankmeldung 
{
    public class Dokument : INotifyPropertyChanged
    {
        string pfad;
        string dateiname;
        string beschreibung;
        string datum;
        KrankerSchueler schueler;
        int id;
        string vorname;
        string name;

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

        public string Dateiname
        {
            get { return dateiname; }
            set
            {
                dateiname = value;
                NotifyPropertyChanged("Dateiname");
            }
        }

        public string Datum
        {
            get { return datum; }
            set
            {
                datum = value;
                NotifyPropertyChanged("Datum");
            }
        }

        public KrankerSchueler Schueler
        {
            get { return schueler; }
            set
            {
                schueler = value;
                NotifyPropertyChanged("Schueler");
            }
        }

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged("Id");
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

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged("Nachname");
            }
        }

        public Dokument(string _pfad, string _beschreibung, string _datum, KrankerSchueler _schueler)
        {
            this.pfad = _pfad;
            this.beschreibung = _beschreibung;
            this.datum = _datum;
            this.schueler = _schueler;

            Dateiname = Dateinameermitteln(pfad);

            this.id = schueler.Schueler.Id;
            this.vorname = schueler.Schueler.Vorname;
            this.name = schueler.Schueler.Name;
        }

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        public string Dateinameermitteln(string Path)
        {
            string Datname = "";

            string[] temp = Path.Split('\\');

            Datname = temp[temp.Length - 1];

            return Datname;
        }

    }
}
