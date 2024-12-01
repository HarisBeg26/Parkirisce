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
    /// Interaction logic for ParkirnaMestaWindow.xaml
    /// </summary>
    public partial class ParkirnaMestaWindow : Window
    {
        private ParkingControl _control = new ParkingControl();
        private ObservableCollection<ParkingSpot> _parkirnaMesta;
        public ParkirnaMestaWindow()
        {
            InitializeComponent();
            _parkirnaMesta = new ObservableCollection<ParkingSpot>();
            TabelaParkirnihMest.ItemsSource = _parkirnaMesta;
        }

        private void DodajParkirnoMesto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var spot = new ParkingSpot
                {
                    Lokacija = Lokacija.Text,
                    Stevilka = int.Parse(Stevilka.Text),
                    Tip = (Tip.SelectedItem as ComboBoxItem)?.Content.ToString()
                };
                _control.DodajParkirnoMesto(spot);
                _parkirnaMesta.Add(spot);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
