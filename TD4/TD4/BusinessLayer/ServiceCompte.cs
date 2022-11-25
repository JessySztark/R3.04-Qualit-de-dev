using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Collections.ObjectModel;
using System.Windows;

namespace BusinessLayer
{
    public class ServiceCompte
    {
        public List<Compte>? GetAllComptes()
        {
            string requete = "SELECT * FROM vComptes";
            List<Compte> comptes = new List<Compte>();
            DataAccess data = new DataAccess();
            DataTable lesDatas = new DataTable();
            try
            {
                lesDatas = data.GetData(requete);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "erreur");
            }
            foreach (DataRow uneDataRow in lesDatas.Rows)
            {
                int idCompte = 0;
                double solde = 0;
                foreach (DataColumn uneDataColumn in lesDatas.Columns)
                {
                    object res = uneDataRow[uneDataColumn];
                    if (res.GetType() == typeof(int))
                    {
                        idCompte = Int32.Parse(res.ToString());
                        MessageBox.Show(idCompte.ToString(), "idcompte");
                    }
                    else if (res.GetType() == typeof(decimal))
                    {
                        solde = Double.Parse(res.ToString());
                        MessageBox.Show(solde.ToString(), "solde");
                    }
                    comptes.Add(new Compte(idCompte, solde));
                }
                
            }
            return comptes;
        }
    }
}
