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
using System.Text.Json;
using System.Text.Json.Serialization;
using Exo1.Models;
using System.IO;
using System.Collections.ObjectModel;

namespace Exo1
{
    private ObservableCollection<Devise> ocDevises = new ObservableCollection<Devise>();

    public ObservableCollection<Devise> OcDevises
    {
        get
        {
            return ocDevises;
        }
        set
        {
            ocDevises = value;
        }
    }
    /// <summary>
    /// Logique d'interaction pour GestionDevises.xaml
    /// </summary>
    /// 

    public partial class GestionDevises : UserControl
    {
        public GestionDevises()
        {
            InitializeComponent();
            String JSONfile = ".\\Data\\Devises.json";
            MessageBox.Show(JSONfile);
            OcDevises = new ObservableCollection<Devise>(JsonSerializer.Deserialize<Devise>(JSONfile);
        }

        public void ReadJSON(string file)
        {
        }

        public void WriteJSON()
        {

        }
    }
}
