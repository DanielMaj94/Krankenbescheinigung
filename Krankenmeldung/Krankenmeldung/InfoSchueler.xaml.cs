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
using System.Windows.Shapes;

namespace Krankenmeldung
{
    /// <summary>
    /// Interaktionslogik für InfoSchueler.xaml
    /// </summary>
    public partial class InfoSchueler : Window
    {
        Schueler schueler;

        MainWindowViewModel meinViewModel;

        public InfoSchueler(MainWindowViewModel ViewModel, Schueler _schueler)
        {
            InitializeComponent();
            meinViewModel = ViewModel;
            this.schueler = _schueler;
            this.DataContext = schueler;
        }

        private void btnOK(object sender, RoutedEventArgs e)
        {
            schueler.Vorname = vorname.Text;
            schueler.Name = nachname.Text;
            schueler.Klasse = klasse.Text;
            schueler.Alter = Int32.Parse(alter.Text);
            schueler.Strasse = strasse.Text;
            schueler.Plz = plz.Text;
            schueler.Ort = ort.Text;
            schueler.Firma = firma.Text;
            schueler.Email = email.Text;

            this.Close();
        }

        private void btnEdit(object sender, RoutedEventArgs e)
        {
            vorname.IsEnabled = true;
            nachname.IsEnabled = true;
            klasse.IsEnabled = true;
            alter.IsEnabled = true;
            strasse.IsEnabled = true;
            plz.IsEnabled = true;
            ort.IsEnabled = true;
            firma.IsEnabled = true;
            email.IsEnabled = true;
        }
    }
}
