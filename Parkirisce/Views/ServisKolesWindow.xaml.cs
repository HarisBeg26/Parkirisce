using Parkirisce.Models;
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

namespace Parkirisce.ViewModels
{
    /// <summary>
    /// Interaction logic for ServisKolesWindow.xaml
    /// </summary>
    public partial class ServisKolesWindow : Window
    {
        private MaintenanceControl _control = new MaintenanceControl();
        private ObservableCollection<Bike> _kolesa;
        public ServisKolesWindow()
        {
            InitializeComponent();
            _kolesa = new ObservableCollection<Bike>();
            TabelaKoles.ItemsSource = _kolesa;
        }

        private void DodajKolo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var kolo = new Bike
                {
                    Id = int.Parse(BikeId.Text),
                    Kilometri = int.Parse(Kilometri.Text),
                    CasVUporabi = int.Parse(CasVUporabi.Text),
                    PotrebaPoServisu = PotrebaPoServisu.IsChecked ?? false
                };
                _control.DodajKolo(kolo);
                _kolesa.Add(kolo);
                BikeId.Clear();
                Kilometri.Clear();
                CasVUporabi.Clear();
                PotrebaPoServisu.IsChecked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
