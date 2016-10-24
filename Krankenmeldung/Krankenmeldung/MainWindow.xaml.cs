using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Krankenmeldung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> AlleKlassen = new List<string>();
        MainWindowViewModel meinViewModel;

        public MainWindow(MainWindowViewModel ViewModel)
        {
            InitializeComponent();
            meinViewModel = ViewModel;
            //this.DataContext = meinViewModel;
            lstData.ItemsSource = meinViewModel.AlleKrankenSchueler;
            AlleKlassen.Add("Alle Klassen");
            foreach (Klasse k in meinViewModel.alleKlassen)
            {
                AlleKlassen.Add(k.Bezeichnung);
            }

            cbKlasse.SelectedValue = "Alle Klassen";
            cbKlasse.ItemsSource = AlleKlassen;

            if (meinViewModel.angemeldeterUser.Equals("ADMIN"))
            {
                btnEinstellungen.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Krankenmelden melden = new Krankenmelden(meinViewModel);
            melden.Show();
        }

        private void btnAkt_Click(object sender, RoutedEventArgs e)
        {
            List<KrankerSchueler> temp = new List<KrankerSchueler>();
            if (DPDatum.Text.Equals(""))
            {
                if (cbKlasse.SelectedValue.Equals("Alle Klassen"))
                {
                    lstData.ItemsSource = null;
                    lstData.ItemsSource = meinViewModel.AlleKrankenSchueler;
                }
                else
                {
                    foreach (KrankerSchueler ks in meinViewModel.AlleKrankenSchueler)
                    {
                        if (ks.Schueler.Klasse.Equals(cbKlasse.SelectedValue))
                        {
                            temp.Add(ks);
                        }
                    }
                    lstData.ItemsSource = null;
                    lstData.ItemsSource = temp;
                }
            }
            else
            {
                foreach (KrankerSchueler ks in meinViewModel.AlleKrankenSchueler)
                {
                    if (DPDatum.Text.Equals(ks.Datum))
                    {
                        if (cbKlasse.SelectedValue.Equals("Alle Klassen"))
                        {
                            temp.Add(ks);
                        }
                        else
                        {
                            if (ks.Schueler.Klasse.Equals(cbKlasse.SelectedValue))
                            {
                                temp.Add(ks);
                            }
                        }
                    }
                }
                lstData.ItemsSource = null;
                lstData.ItemsSource = temp;
            }
        }

        private void btnDokument_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("");
            new DokumenteAnzeigen(meinViewModel).Show();
        }

        private void cbKlasse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void wMainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            meinViewModel.AlleDokumenteSchreiben();
            meinViewModel.AlleKlassenSchreiben();
            meinViewModel.AlleKrankenSchuelerSchreiben();
            meinViewModel.AlleLehrerSchreiben();
            meinViewModel.AlleSchuelerSchreiben();
            Environment.Exit(0);
        }

        private void cbDatum_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnEinstellungen_Click(object sender, RoutedEventArgs e)
        {
            Einstellungen einst = new Einstellungen(meinViewModel);
            einst.Show();
        }
    }
}
