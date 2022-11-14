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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessLayer;

namespace Exo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Compte> lesComptes = new ObservableCollection<Compte>();
        private ObservableCollection<String> lesTypesOperations = new ObservableCollection<String>();

        public ObservableCollection<Compte> LesComptes
        {
            get { 
                return lesComptes; 
            }
            set { 
                lesComptes = value; 
            }
        }

        public ObservableCollection<String> LesTypesOperations
        {
            get { 
                return lesTypesOperations; 
            }
            set { 
                lesTypesOperations = value; 
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            ServiceCompte objCompte = new ServiceCompte();
            LesComptes = new ObservableCollection<Compte>(objCompte.GetAllComptes());

            LesTypesOperations = new ObservableCollection<String>();
            LesTypesOperations.Add("Retrait");
            LesTypesOperations.Add("Dépôt");
        }

        private void btValider_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Opération : {cbxTypeOpe.Text} \nCompte : {cbxCompte.Text} \nMontant : {textBoxMontant.Text}");
        }
        // ok
        private void btAnnuler_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
