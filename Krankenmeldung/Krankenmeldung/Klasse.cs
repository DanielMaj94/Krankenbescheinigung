using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krankenmeldung
{
    public class Klasse : INotifyPropertyChanged
    {
        string bezeichnung;
        Lehrer klassenlehrer;
        int klassengroeße;
        List<Schueler> krankeSchueler = new List<Schueler>();
        List<Schueler> alleSchueler = new List<Schueler>();

        public event PropertyChangedEventHandler PropertyChanged;


        public string Bezeichnung
        {
            get { return bezeichnung; }
            set
            {
                bezeichnung = value;
                NotifyPropertyChanged("Bezeichnung");
            }
        }

        internal Lehrer Klassenlehrer
        {
            get { return klassenlehrer; }
            set
            {
                klassenlehrer = value;
                NotifyPropertyChanged("Klassenlehrer");
            }
        }

        public int Klassengroeße
        {
            get { return klassengroeße; }
            set
            {
                klassengroeße = value;
                NotifyPropertyChanged("Klassengroeße");
            }
        }

        internal List<Schueler> KrankeSchueler
        {
            get { return krankeSchueler; }
            set
            {
                krankeSchueler = value;
                NotifyPropertyChanged("KrankeSchueler");
            }
        }

        internal List<Schueler> AlleSchueler
        {
            get { return alleSchueler; }
            set
            {
                alleSchueler = value;
                NotifyPropertyChanged("AlleSchueler");
            }
        }

        public Klasse(string _bezeichnung, Lehrer _klassenlehrer)
        {
            this.bezeichnung = _bezeichnung;
            this.klassenlehrer = _klassenlehrer;
        }

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
