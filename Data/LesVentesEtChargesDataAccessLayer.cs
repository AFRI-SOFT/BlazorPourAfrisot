using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CRUDBlazor.Data
{
    public class LesVentesEtChargesDataAccessLayer
    {
        string connectionString = ClassVariableGlobal.connectionString;




        public LesVentesEtCharges GetVenteJournaliere(DateTime date1, DateTime date2)
        {
            LesVentesEtCharges listeVenteJ = new LesVentesEtCharges();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                int daysDiff = Math.Abs(((TimeSpan)(date2 - date1)).Days + 1);
                string s = "SELECT        tCompte.NumCompte, SUM(tMvtCompte.Entree) AS SDebitCharge, SUM(tMvtCompte.Sortie) AS SCreditProduit, tCompte.DesignationCompte, " +
  "((tObjectif.VenteJournalier) * " + daysDiff + ") as ObjectifVenteJournalier, (SUM(tMvtCompte.Sortie) / ((tObjectif.VenteJournalier)* " + daysDiff + ") * 100) AS PourCentageVente " +
" FROM tCompte INNER JOIN " +
                         " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                        "  tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation CROSS JOIN " +
                        "  tObjectif" +
" WHERE(tOperation.DateOp between  @da and  @db) " +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tObjectif.VenteJournalier" +
" HAVING(tCompte.NumCompte = 7000000)";

                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@da", date1);
                cmd.Parameters.AddWithValue("@db", date2);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listeVenteJ.SCreditProduit = Convert.ToDouble(rdr["SCreditProduit"]);
                    listeVenteJ.ObjectifVenteJournalier = Convert.ToDouble(rdr["ObjectifVenteJournalier"]);
                    listeVenteJ.PourCentageVente = Convert.ToDouble(rdr["PourCentageVente"]);
                    listeVenteJ.DesignationCompte = rdr["DesignationCompte"].ToString();
                    listeVenteJ.NumCompte = rdr["NumCompte"].ToString();
                   //Customer.Country = rdr["Country"].ToString();
                   // Customer.City = rdr["City"].ToString();
                }
            }
            return listeVenteJ;
        }


        public LesVentesEtCharges GetChargeStockage(DateTime date1, DateTime date2)
        {
            LesVentesEtCharges listeVenteJ = new LesVentesEtCharges();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                int daysDiff = Math.Abs(((TimeSpan)(date2 - date1)).Days + 1);
                string s = "SELECT        tCompte.NumCompte, SUM(tMvtCompte.Entree) AS SEntree, SUM(tMvtCompte.Sortie) AS SSortie, tCompte.DesignationCompte "+
 " FROM tCompte INNER JOIN " +
                         " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN  " +
                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation " +
" WHERE(tOperation.DateOp BETWEEN @da AND @db) " +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte " +
" HAVING(tCompte.NumCompte = 6000000)";

                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@da", date1);
                cmd.Parameters.AddWithValue("@db", date2);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listeVenteJ.SDebitCharge = Convert.ToDouble(rdr["SDebitCharge"]);
                   // listeVenteJ.ObjectifVenteJournalier = Convert.ToDouble(rdr["ObjectifVenteJournalier"]);
                  //  listeVenteJ.PourCentageVente = Convert.ToDouble(rdr["PourCentageVente"]);
                    listeVenteJ.DesignationCompte = rdr["DesignationCompte"].ToString();
                    listeVenteJ.NumCompte = rdr["NumCompte"].ToString();
                    //Customer.Country = rdr["Country"].ToString();
                    // Customer.City = rdr["City"].ToString();
                }
            }
            return listeVenteJ;
        }

    }


}
