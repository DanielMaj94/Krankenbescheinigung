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
        MainWindowViewModel meinViewModel = new MainWindowViewModel();

        public LoginGUI()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Benutzername = tbBenutzername.Text;
            string Passwort = tbPasswort.Text;
            bool gefunden = false;

            foreach(Lehrer l in meinViewModel.AlleLehrer)
            {
                if(Benutzername.Equals(l.Benutzername))
                {
                    if(Passwort.Equals(l.Passwort))
                    {
                        gefunden = true;
                        MainWindow window = new MainWindow(meinViewModel);
                        window.Show();
                    }
                }
            }

            if(!gefunden)
            {
                MessageBox.Show("Fehlerhafte Anmeldung", "Anmeldung", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
