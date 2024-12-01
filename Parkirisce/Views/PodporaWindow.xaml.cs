using Parkirisce.Models;
using Parkirisce.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Parkirisce.Views
{
    /// <summary>
    /// Interaction logic for PodporaWindow.xaml
    /// </summary>
    public partial class PodporaWindow : Window
    {
        private SupportControl _control = new SupportControl();
        private ObservableCollection<SupportTicket> _zahteve;
        public PodporaWindow()
        {
            InitializeComponent();
            _zahteve = new ObservableCollection<SupportTicket>();
            TabelaZahtev.ItemsSource = _zahteve;
        }

        private void DodajZahtevo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var zahteva = new SupportTicket
                {
                    Id = _zahteve.Count + 1,
                    PodrobnostiTezave = Tezava.Text,
                    Status = "Nova"
                };
                _control.DodajZahtevo(zahteva);
                _zahteve.Add(zahteva);
                Tezava.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
