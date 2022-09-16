using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using Calculatrice;

namespace Exo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Double resultat;
        private Double nb1;
        private Double nb2;

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public double Resultat
        {
            get
            {
                return resultat;
            }

            set
            {
                resultat = value;
                OnPropertyChanged("Resultat");
            }
        }

        public double Nb1
        {
            get
            {
                return nb1;
            }

            set
            {
                nb1 = value;
            }
        }

        public double Nb2
        {
            get
            {
                return nb2;
            }

            set
            {
                nb2 = value;
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    private void Baddition_Click(object sender, RoutedEventArgs e)
        {
            Calcul.Addition(Nb1, Nb2, out resultat);
        }

        private void Bsoustraction_Click(object sender, RoutedEventArgs e)
        {
            Calcul.Soustraction(Nb1, Nb2, out resultat);
        }

        private void Bmultiplication_Click(object sender, RoutedEventArgs e)
        {
            Calcul.Multiplication(Nb1, Nb2, out resultat);
        }

        private void Bdivision_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Calcul.Division(Nb1, Nb2, out resultat);
            }
            catch(Exception exc)
            {
                MessageBox.Show($"{exc}");
            }
        }
        private void Bfactorielle_Click(object sender, RoutedEventArgs e)
        {
            Calcul.Factorielle(Nb1, out resultat);
        }
    }
}
