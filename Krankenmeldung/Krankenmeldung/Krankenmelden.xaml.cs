using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für Krankenmelden.xaml
    /// </summary>
    public partial class Krankenmelden : Window
    {
        List<string> AlleKlassen = new List<string>();
        List<string> listeSchueler = new List<string>();
        List<string> listeStatus = new List<string>();
        Schueler tempschueler = null;
        KrankerSchueler SchulerKrank;

        MainWindowViewModel meinViewModel;

        public Krankenmelden(MainWindowViewModel ViewModel)
        {
            InitializeComponent();
            meinViewModel = ViewModel;

            foreach(Klasse k in meinViewModel.alleKlassen)
            {
                //MessageBox.Show(k.Bezeichnung);
                AlleKlassen.Add(k.Bezeichnung);
            }

            listeStatus.Add("Unentschuldigt Abwesend");
            listeStatus.Add("Entschuldigt Abwesend");
            listeStatus.Add("Beurlaubt");
            listeStatus.Add("Sonstiges");

            cbKlasse.ItemsSource = AlleKlassen;
            cbStatus.ItemsSource = listeStatus;
        }

        private void cbKlasse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbSchueler.SelectedValue = "";
            btnHochladen.IsEnabled = false;
            listeSchueler.Clear();

            //foreach (string s in meinViewModel.KlassenlehrerVon)
            //{
            //    //MessageBox.Show("" + s);
            //    if (s.Equals(cbKlasse.SelectedValue))
            //    {
            //        //btnHochladen.IsEnabled = true;
            //    }
            //}

            foreach(Schueler s in meinViewModel.alleSchueler)
            {
                if (s.Klasse.Equals("" + cbKlasse.SelectedValue))
                {
                    listeSchueler.Add(s.Id + ". " + s.Name + " " + s.Vorname);
                }
            }

            cbSchueler.ItemsSource = listeSchueler;
            cbKlasse.IsEnabled = false;
        }

        private void btnKrankmelden_Click(object sender, RoutedEventArgs e)
        {
            if(tempschueler.Equals(null))
            {
                MessageBox.Show("Bitte wählen sie einen Schüler aus");
            }
            else
            {
                MessageBox.Show("Ich bin jetzt hier");
                SchulerKrank = new KrankerSchueler(meinViewModel.alleKrankenSchueler.Count, tempschueler, DateDatum.Text, tbuhrzeitVon.Text, tbuhrzeitBis.Text, "" + cbStatus.SelectedValue);
                meinViewModel.AlleKrankenSchueler.Add(SchulerKrank);
            }
            Close();
        }

        private void cbSchueler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("" + cbSchueler.SelectedValue);
            string[] temp = cbSchueler.SelectedValue.ToString().Split('.');

            foreach(Schueler s in meinViewModel.alleSchueler)
            {
                if(Int32.Parse(temp[0]) == s.Id)
                {
                    tempschueler = s;
                    btnSchülerinfo.IsEnabled = true;
                    btnHochladen.IsEnabled = true;
                    btnKrankmelden.IsEnabled = true;
                    DateDatum.IsEnabled = true;
                    tbuhrzeitBis.IsEnabled = true;
                    tbuhrzeitVon.IsEnabled = true;
                    cbStatus.IsEnabled = true;
                }
            }
        }

        private void btnSchülerinfo_Click(object sender, RoutedEventArgs e)
        {
            InfoSchueler info = new InfoSchueler(meinViewModel, tempschueler);
            info.Show();
        }

        private void btnHochladen_Click(object sender, RoutedEventArgs e)
        {
            if (tempschueler.Equals(null))
            {
                MessageBox.Show("Bitte wählen sie einen Schüler aus");
            }
            else
            {
                MessageBox.Show("Ich bin jetzt hier");
                SchulerKrank = new KrankerSchueler(meinViewModel.alleKrankenSchueler.Count, tempschueler, DateDatum.Text, tbuhrzeitVon.Text, tbuhrzeitBis.Text, "" + cbStatus.SelectedValue);
                UploadDokument up = new UploadDokument(meinViewModel, SchulerKrank);
                up.Show();
            }
        }

        
    }
}
