using Parkirisce.ViewModels;
using Parkirisce.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parkirisce
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_AddParking_Click(object sender, RoutedEventArgs e)
        {
            var parkirnaMestaWindow = new ParkirnaMestaWindow();
            parkirnaMestaWindow.Show();
        }

        private void btn_SupportHelp_Click(object sender, RoutedEventArgs e)
        {
            var support = new PodporaWindow();
            support.Show();
        }

        private void btn_Repair_Click(object sender, RoutedEventArgs e)
        {
            var servis = new ServisKolesWindow();
            servis.Show();  
        }
    }
}