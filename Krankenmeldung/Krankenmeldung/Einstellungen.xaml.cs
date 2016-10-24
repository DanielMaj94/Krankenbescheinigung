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
    /// Interaktionslogik für Einstellungen.xaml
    /// </summary>
    public partial class Einstellungen : Window
    {
        MainWindowViewModel meinViewModel;
        public Einstellungen(MainWindowViewModel ViewModel)
        {
            InitializeComponent();
            meinViewModel = ViewModel;

            cbListe.Items.Add("Alles Formatieren");
            cbListe.Items.Add("Lehrer");
            cbListe.Items.Add("Klassen");
            cbListe.Items.Add("Schüler");
            cbListe.Items.Add("Kranken Schüler");
            cbListe.Items.Add("Dokumente");
        }

        private void btnFormatieren_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Sind sie sich sicher?", "Sicher?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(res == MessageBoxResult.Yes)
            {
                if(cbListe.Text.Equals("Lehrer"))
                {
                    meinViewModel.ListenLoeschen(meinViewModel.alleLehrer);
                }
                else if (cbListe.Text.Equals("Klassen"))
                {
                    meinViewModel.ListenLoeschen(meinViewModel.alleKlassen);
                }
                else if (cbListe.Text.Equals("Schüler"))
                {
                    meinViewModel.ListenLoeschen(meinViewModel.alleSchueler);
                }
                else if (cbListe.Text.Equals("Kranke Schüler"))
                {
                    meinViewModel.ListenLoeschen(meinViewModel.alleKrankenSchueler);
                }
                else if (cbListe.Text.Equals("Dokumente"))
                {
                    meinViewModel.ListenLoeschen(meinViewModel.alleDokumente);
                    DirectoryInfo d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "Dokumente");
                    d.Delete(true);
                    
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Dokumente");
                }
            }
            else
            {
                MessageBox.Show("Abgebrochen");
            }
        }
    }
}
