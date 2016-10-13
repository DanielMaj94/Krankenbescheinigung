using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krankenmeldung
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        List<Lehrer> AlleLehrer = new List<Lehrer>();
        List<Klasse> AlleKlassen = new List<Klasse>();

        public MainWindowViewModel()
        {

        }

        public void AlleLehrerSpeichern()
        {

        }
    }
}
