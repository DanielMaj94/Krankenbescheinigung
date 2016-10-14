using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krankenmeldung
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Lehrer> AlleLehrer = new List<Lehrer>();
        public List<Klasse> AlleKlassen = new List<Klasse>();
        public List<Schueler> AlleSchueler = new List<Schueler>();

        public List<Klasse> alleKlassen
        {
            get { return AlleKlassen; }
            set { AlleKlassen = value; }
        }

        public MainWindowViewModel()
        {
            AlleLehrerSpeichern();
            AlleKlassenSpeichern();
        }

        public void AlleLehrerSpeichern()
        {
            using (System.IO.StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Lehrerkuerzel.csv"))
            {
                string zeile = "";
                while ((zeile = reader.ReadLine()) != null)
                {
                    string[] lehrer = zeile.Split(';');

                    AlleLehrer.Add(new Lehrer(lehrer[0], lehrer[1], lehrer[2], lehrer[3], lehrer[4]));
                }

            }
        }
        
        public void AlleKlassenSpeichern()
        {
            using (System.IO.StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Klassen.csv"))
            {
                string zeile = "";
                Lehrer lehrer = null;
                while ((zeile = reader.ReadLine()) != null)
                {
                    string[] klasse = zeile.Split(';');

                    foreach(Lehrer l in AlleLehrer)
                    {
                        if (l.Kuerzel.Equals(klasse[1]))
                        {
                            lehrer = l;
                        }
                    }

                    AlleKlassen.Add(new Klasse(klasse[0], lehrer));
                }

            }
        }

        public void AlleSchuelerSpeichern()
        {
            using (System.IO.StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Schueler.csv"))
            {
                string zeile = "";

                while ((zeile = reader.ReadLine()) != null)
                {
                    string[] schueler = zeile.Split(';');

                    AlleSchueler.Add(new Schueler(schueler[0], schueler[1], Int16.Parse(schueler[2]), schueler[3], schueler[4], schueler[5], schueler[6], schueler[7], schueler[8]));
                }
            }
        }
    }
}
