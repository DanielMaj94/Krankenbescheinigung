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
    /// Interaktionslogik für LoginGUI.xaml
    /// </summary>
    public partial class LoginGUI : Window
    {
        MainWindowViewModel meinViewModel;

        public LoginGUI()
        {
            InitializeComponent();
            meinViewModel = new MainWindowViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Benutzername = tbBenutzername.Text;
            string Passwort = tbPasswort.Password;
            bool gefunden = false;

            foreach (Lehrer l in meinViewModel.alleLehrer)
            {
                if (Benutzername.Equals(l.Benutzername))
                {
                    if (Passwort.Equals(l.Passwort))
                    {
                        gefunden = true;
                        meinViewModel.angemeldeterUser = l.Kuerzel;
                        //MessageBox.Show(meinViewModel.angemeldeterUser);
                        meinViewModel.KlasseSpeichernKL();
                        MainWindow window = new MainWindow(meinViewModel);
                        window.Show(); 
                        Close();
                    }
                }
            }

            if (!gefunden)
            {
                MessageBox.Show("Fehlerhafte Anmeldung", "Anmeldung", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
