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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GestionDevises gd = new GestionDevises();
            ContentCtrl.Content = gd;
        }
        private void ConvertisseurDevise_Button_Click(object sender, RoutedEventArgs e)
        {
            ConvertisseurDevise cd = new ConvertisseurDevise();
            ContentCtrl.Content = cd;
        }
        private void ConvertisseurEuro_Button_Click(object sender, RoutedEventArgs e)
        {
            ConvertisseurEuro ce = new ConvertisseurEuro();
            ContentCtrl.Content = ce;
        }

        private void GestionDevises_Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
