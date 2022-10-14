﻿using System;
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

        ObservableCollection<Compte> LesComptes = new ObservableCollection<Compte>();
        ComboBox cbCompte;
        ObservableCollection<String> LesTypesOperations = new ObservableCollection<String>();


        public MainWindow()
        {
            InitializeComponent();
            LesTypesOperations.Add("Retrait");
            LesTypesOperations.Add("Dépôt");
            this.DataContext = this;

        }
    }
}
