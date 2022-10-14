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
    /// <summary>
    /// Logique d'interaction pour GestionDevises.xaml
    /// </summary>
    /// 

    public partial class GestionDevises : UserControl
    {
        private ObservableCollection<Devise> ocDevises;

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

        public GestionDevises()
        {
            InitializeComponent();
            String JSONfile = "Data\\Devises.json";
            String JSONString = File.ReadAllText(JSONfile);
            ReadJSON(JSONString);
        }

        public void ReadJSON(string file)
        {
            OcDevises = new ObservableCollection<Devise>(new List<Devise>());
            for (int i = 0; i < 2; i++)
            {
                OcDevises.Add(new Devise(JsonSerializer.Deserialize<Devise>(file).NomDevise, JsonSerializer.Deserialize<Devise>(file).Taux));
                MessageBox.Show(OcDevises[i].ToString());
            }
        }

        public void WriteJSON()
        {

        }
    }
}