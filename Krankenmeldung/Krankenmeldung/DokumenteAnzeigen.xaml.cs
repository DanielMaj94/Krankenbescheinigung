using Krankmeldung;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Krankenmeldung
{
    /// <summary>
    /// Interaktionslogik für DokumenteAnzeigen.xaml
    /// </summary>
    public partial class DokumenteAnzeigen : Window
    {
        MainWindowViewModel meinViewModel;
        List<Dokument> ListeDerDokumente = new List<Dokument>();

        public DokumenteAnzeigen(MainWindowViewModel ViewModel)
        {
            InitializeComponent();
            meinViewModel = ViewModel;
            lstData.ItemsSource = meinViewModel.alleDokumente;
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(AppDomain.CurrentDomain.BaseDirectory + "Dokumente\\"));
            List<string> neudirs = new List<string>();
            neudirs.Add("Alle Tage");
            foreach(string s in dirs)
            {
                string ts = s.Replace(AppDomain.CurrentDomain.BaseDirectory + "Dokumente\\", "");
                ts = ts.Replace("-", ".");
                neudirs.Add(ts);
            }
            cbDatum.ItemsSource = neudirs;

            List<string> alleKlassen = new List<string>();
            alleKlassen.Add("Alle Klassen");
            foreach(Klasse k in meinViewModel.alleKlassen)
            {
                alleKlassen.Add(k.Bezeichnung);
            }

            cbKlasse.ItemsSource = alleKlassen;

            cbKlasse.SelectedValue = "Alle Klassen";
            cbDatum.SelectedValue = "Alle Tage";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = lstData.SelectedIndex;

            if(File.Exists(meinViewModel.alleDokumente.ElementAt(index).Pfad))
            {
                Process.Start(meinViewModel.alleDokumente.ElementAt(index).Pfad);
            }
            else
            {
                MessageBox.Show("Die Datei wurde aus dem System entfernt", "Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void cbDatum_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAkt_Click(object sender, RoutedEventArgs e)
        {
            ListeDerDokumente.Clear();
            lstData.ItemsSource = null;

            if(cbKlasse.SelectedValue.Equals("Alle Klassen"))
            {
                if(cbDatum.SelectedValue.Equals("Alle Tage"))
                {
                    lstData.ItemsSource = meinViewModel.alleDokumente;
                }
                else
                {
                    foreach (Dokument d in meinViewModel.alleDokumente)
                    {
                        if (d.Datum.Equals(cbDatum.SelectedValue))
                        {
                            ListeDerDokumente.Add(d);
                            lstData.ItemsSource = ListeDerDokumente;
                        }
                    }
                }
            }
            else
            {
                foreach (Dokument dok in meinViewModel.alleDokumente)
                {
                    if (cbKlasse.SelectedValue.Equals(dok.Schueler.Schueler.Klasse))
                    {

                        if (cbDatum.SelectedValue.Equals("Alle Tage"))
                        {
                            ListeDerDokumente.Add(dok);
                        }
                        else
                        {
                            if (dok.Datum.Equals(cbDatum.SelectedValue))
                            {
                                ListeDerDokumente.Add(dok);
                            }
                        }
                    }
                }
                lstData.ItemsSource = ListeDerDokumente;
            }
        }

        private void lstData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
