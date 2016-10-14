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
        MainWindowViewModel meinViewModel;

        public Krankenmelden(MainWindowViewModel ViewModel)
        {
            InitializeComponent();
            meinViewModel = ViewModel;

            foreach(Klasse k in meinViewModel.alleKlassen)
            {
                MessageBox.Show(k.Bezeichnung);
                AlleKlassen.Add(k.Bezeichnung);
            }

            cbKlasse.ItemsSource = AlleKlassen;
        }

        private void cbKlasse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(""+cbKlasse.SelectedValue);
            foreach(Schueler s in meinViewModel.AlleSchueler)
            {
                if(s.Klasse.Equals(""+cbSchueler.SelectedValue))
                {
                    listeSchueler.Add(s.Name + " " + s.Vorname);
                }
            }

            cbSchueler.ItemsSource = listeSchueler;
        }

        
    }
}
