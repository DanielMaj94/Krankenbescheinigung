using Krankmeldung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Krankenmeldung
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string angemeldeterUser = "";
        public List<string> KlassenlehrerVon = new List<string>();
        List<string> dirs = new List<string>(Directory.EnumerateDirectories(AppDomain.CurrentDomain.BaseDirectory + "Dokumente\\"));
        List<string> OrdnerDatum = new List<string>();
        List<string> listeAllerDateien = new List<string>();

        public List<Lehrer> alleLehrer = new List<Lehrer>();
        public List<Klasse> alleKlassen = new List<Klasse>();
        public List<Schueler> alleSchueler = new List<Schueler>();
        public List<KrankerSchueler> alleKrankenSchueler = new List<KrankerSchueler>();
        public List<Dokument> alleDokumente = new List<Dokument>();


        public List<Klasse> AlleKlassen
        {
            get { return alleKlassen; }
            set { alleKlassen = value; }
        }

        public List<KrankerSchueler> AlleKrankenSchueler
        {
            get { return alleKrankenSchueler; }
            set { alleKrankenSchueler = value; }
        }

        public MainWindowViewModel()
        {
            ListeDir();
            AlleLehrerSpeichern();
            AlleKlassenSpeichern();
            AlleSchuelerSpeichern();
            AlleKrankenSpeichern();
            AlleDokumenteSpeichern();
        }

        public void KlasseSpeichernKL()
        {
            foreach (Klasse k in AlleKlassen)
            {
                //MessageBox.Show("Das da: " + angemeldeterUser);
                if (k.Klassenlehrer.Kuerzel.Equals(angemeldeterUser))
                {
                    //MessageBox.Show("hier: " + k.Bezeichnung);
                    KlassenlehrerVon.Add(k.Bezeichnung);
                }
            }
        }

        public void AlleLehrerSpeichern()
        {
            using (System.IO.StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Lehrerkuerzel.csv"))
            {
                string zeile = "";
                while ((zeile = reader.ReadLine()) != null)
                {
                    string[] lehrer = zeile.Split(';');

                    alleLehrer.Add(new Lehrer(lehrer[0], lehrer[1], lehrer[2], lehrer[3], lehrer[4]));
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

                    foreach(Lehrer l in alleLehrer)
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

                    alleSchueler.Add(new Schueler(Int16.Parse(schueler[0]), schueler[1], schueler[2], Int16.Parse(schueler[3]), schueler[4], schueler[5], schueler[6], schueler[7], schueler[8], schueler[9]));
                }
            }
        }

        public void AlleKrankenSpeichern()
        {
            Schueler tempS = null;
            using (System.IO.StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "KrankeSchueler.csv"))
            {
                string zeile = "";

                while ((zeile = reader.ReadLine()) != null)
                {
                    string[] schueler = zeile.Split(';');

                    foreach (Schueler s in alleSchueler)
                    {
                        //MessageBox.Show("" + schueler[1]);
                        if (s.Id == Int16.Parse(schueler[1]))
                        {
                            //MessageBox.Show("-......" + schueler[1]);
                            tempS = s;
                        }
                    }

                    if(tempS != null)
                    {
                        alleKrankenSchueler.Add(new KrankerSchueler(Int32.Parse(schueler[0]), tempS, schueler[2], schueler[3], schueler[4], schueler[5]));
                    }

                }
            }
        }
    
        public void AlleDokumenteSpeichern()
        {
            KrankerSchueler tempKS = null;
            using (System.IO.StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Dokumente.csv"))
            {
                string zeile = "";

                while ((zeile = reader.ReadLine()) != null)
                {
                    string[] schueler = zeile.Split(';');

                    foreach (KrankerSchueler s in alleKrankenSchueler)
                    {
                        if (s.Id == Int32.Parse(schueler[3]))
                        {
                            tempKS = s;
                        }
                    }

                    if (tempKS != null)
                    {
                        alleDokumente.Add(new Dokument(schueler[0], schueler[1], schueler[2], tempKS));
                    }
                }
            }
        }

        public void ListeDir()
        {
            foreach(string s in dirs)
            {
                OrdnerDatum.Add(s);
            }

            foreach(string od in OrdnerDatum)
            {
                List<string> temp = new List<string>(Directory.EnumerateFiles(od));

                foreach(string t in temp)
                {
                    listeAllerDateien.Add(t);
                }
            }
        }

        /**
         * Leere Ordner löschen
         */

        public void LeereOrdnerLoeschen()
        {
            
        }

        public void ListenLoeschen<T>(List<T> Liste)
        {
            Liste.Clear();
        }
    
        public void AlleDokumenteSchreiben()
        {
            using(System.IO.StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Dokumente.csv"))
            {
                foreach(Dokument d in alleDokumente)
                {
                    if (File.Exists(d.Pfad))
                    {
                        string dok = d.Pfad + ";" + d.Beschreibung + ";" + d.Datum + ";" + d.Schueler.Id + "\r\n";
                        writer.Write(dok);
                    }
                }
            }
        }

        public void AlleSchuelerSchreiben()
        {
            using (System.IO.StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Schueler.csv"))
            {
                foreach (Schueler d in alleSchueler)
                {
                    string sch = d.Id + ";" + d.Name + ";" + d.Vorname + ";" + d.Alter + ";" + d.Strasse + ";" + d.Plz + ";" + d.Ort + ";" + d.Firma + ";" + d.Email + ";" + d.Klasse + "\r\n";
                    writer.Write(sch);
                }
            }
        }

        public void AlleKrankenSchuelerSchreiben()
        {
            using (System.IO.StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "KrankeSchueler.csv"))
            {
                foreach (KrankerSchueler d in alleKrankenSchueler)
                {
                    string sch = d.Id + ";" + d.Schueler.Id + ";" + d.Datum + ";" + d.Uhrzeit + ";" + d.UhrzeitBis + ";" + d.Status + "\r\n";
                    writer.Write(sch);
                }
            }
        }

        public void AlleKlassenSchreiben()
        {
            using (System.IO.StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Klassen.csv"))
            {
                foreach (Klasse d in alleKlassen)
                {
                    string kl = d.Bezeichnung + ";" + d.Klassenlehrer.Kuerzel + "\r\n";
                    writer.Write(kl);
                }
            }
        }

        public void AlleLehrerSchreiben()
        {
            using (System.IO.StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Lehrerkuerzel.csv"))
            {
                foreach (Lehrer d in alleLehrer)
                {
                    string l = d.Kuerzel + ";" + d.Name + ";" + d.Vorname + ";" + d.Benutzername + ";" + d.Passwort + "\r\n";
                    writer.Write(l);
                }
            }
        }
    }
}
