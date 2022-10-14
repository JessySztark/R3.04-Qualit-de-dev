using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Collections.ObjectModel;

namespace BusinessLayer
{
    public class ServiceCompte
    {
        public List<Compte>? GetAllComptes()
        {
            string requete = "SELECT * FROM vw_compte";
            List<Compte> comptes = new List<Compte>();
            DataAccess data = new DataAccess();
            DataTable? lesDatas = data.GetData(requete);
            foreach (DataRow uneData in lesDatas.Rows)
                comptes.Add(new Compte(Convert.ToInt32(uneData[0]), Convert.ToDouble(uneData[1])));
            return comptes;
        }
    }
}
