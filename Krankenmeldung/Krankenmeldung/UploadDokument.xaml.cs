using Krankmeldung;
using Microsoft.Win32;
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
    /// Interaktionslogik für UploadDokument.xaml
    /// </summary>
    public partial class UploadDokument : Window
    {
        string quelldatei;
        string zielpfad;
        KrankerSchueler newSchueler;

        MainWindowViewModel meinViewModel;

        public UploadDokument(MainWindowViewModel ViewModel, KrankerSchueler schueler)
        {
            InitializeComponent();
            meinViewModel = ViewModel;
            Ordnererstellen();
            newSchueler = schueler;
        }

        public void Ordnererstellen()
        {
            string myTimeOrdner = System.DateTime.Now.ToShortDateString();
            myTimeOrdner = myTimeOrdner.Replace('.', '-');
            System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Dokumente\\" + myTimeOrdner);
        }

        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            quelldatei = dialog.FileName;

            MessageBox.Show(quelldatei);
        }

        private string DateitypErmitteln(string Path)
        {
            string Dateityp = "";

            string[] arr = Path.Split('.');

            Dateityp = arr[arr.Length-1];

            return Dateityp;
        }

        private void btnhochladen_Click(object sender, RoutedEventArgs e)
        {
            string Dateityp = DateitypErmitteln(quelldatei);
            string pfad = (AppDomain.CurrentDomain.BaseDirectory + "Dokumente\\" + System.DateTime.Now.ToShortDateString().Replace('.', '-') + "\\" + tbTitel.Text + "." + Dateityp);
            zielpfad = (AppDomain.CurrentDomain.BaseDirectory + "Dokumente\\" + System.DateTime.Now.ToShortDateString().Replace('.', '-') + "\\" + tbTitel.Text + "." + Dateityp);

            if(File.Exists(zielpfad))
            {
                MessageBox.Show("Die Datei existiert schon", "Dateifehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                File.Copy(quelldatei, zielpfad);

                meinViewModel.alleDokumente.Add(new Dokument(pfad, tbBemerkung.Text, System.DateTime.Now.ToShortDateString(), newSchueler));

                Close();
            }
        }

        private void btnAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
