using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRUDBlazor.Data
{
    public class LesStockDataAccessLayer
    {
        //  string connectionString = "Data Source=DESKTOP-6LF9CSG;Initial Catalog=BasPAmojaNayesu2018;Integrated Security=false ;User ID=MANDAL; Password =12345678";
        //To View all Customers details 
        string connectionString = ClassVariableGlobal.connectionString; //"Data Source=DESKTOP-6LF9CSG;Initial Catalog=BasPAmojaNayesu2018;Integrated Security=false ;User ID=MANDAL; Password =12345678";
        //To View all Customers details 
        public IEnumerable<LesStocks> GetLesStocks()
        {
            List<LesStocks> lstCustomer = new List<LesStocks>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string s = "SELECT        tStock.CodeMarchandise, tStock.DesignationMarchandise, SUM(tMouvementDepot.QteEntree) AS SQteEntree, SUM(tMouvementDepot.QteSortie) AS SQteSortie,Round(SUM(tMouvementDepot.QteEntree)-SUM(tMouvementDepot.QteSortie),2) AS Stock " +
" FROM tMouvementDepot INNER JOIN " +
                         " tStock ON tMouvementDepot.CodeMarchandise = tStock.CodeMarchandise INNER JOIN " +
                        "  tOperationDepot ON tMouvementDepot.NumOperation = tOperationDepot.NumOperation " +
" GROUP BY tStock.CodeMarchandise, tStock.DesignationMarchandise";
               // SqlCommand cmd = new SqlCommand("usp_GetAllCustomers", con);
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    LesStocks stock = new LesStocks();
                    stock.CodeMarchandise = (rdr["CodeMarchandise"]).ToString();
                    stock.DesignationMarchandise= rdr["DesignationMarchandise"].ToString();
                    stock.Stock = Convert.ToDouble (rdr["Stock"]);
                    // Customer.Country = rdr["Country"].ToString();
                    //Customer.City = rdr["City"].ToString();
                    lstCustomer.Add(stock);
                }
                con.Close();
            }
            return lstCustomer;
        }




        public IEnumerable<LesStocks> GetLesStockParDepot( string codeMarchandise)
        {
            List<LesStocks> lstCustomer = new List<LesStocks>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string s = "SELECT        tStock.CodeMarchandise, tStock.DesignationMarchandise, SUM(tMouvementDepot.QteEntree) AS SQteEntree, SUM(tMouvementDepot.QteSortie) AS SQteSortie, ROUND(SUM(tMouvementDepot.QteEntree)  " +
                     "      - SUM(tMouvementDepot.QteSortie), 2) AS Stock, tDepot.CodeDepot, tDepot.DesignationDepot " +
 " FROM            tMouvementDepot INNER JOIN " +
                         " tStock ON tMouvementDepot.CodeMarchandise = tStock.CodeMarchandise INNER JOIN " +
                         " tOperationDepot ON tMouvementDepot.NumOperation = tOperationDepot.NumOperation INNER JOIN " +
                        "  tDepot ON tMouvementDepot.CodeDepot = tDepot.CodeDepot " +
" GROUP BY tStock.CodeMarchandise, tStock.DesignationMarchandise, tDepot.CodeDepot, tDepot.DesignationDepot " +
" HAVING(tStock.CodeMarchandise = @a)";
                // SqlCommand cmd = new SqlCommand("usp_GetAllCustomers", con);
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@a", codeMarchandise);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    LesStocks stock = new LesStocks();
                    stock.CodeMarchandise = (rdr["CodeMarchandise"]).ToString();
                    stock.DesignationMarchandise = rdr["DesignationMarchandise"].ToString();
                    stock.DesignationDepot = rdr["DesignationDepot"].ToString();
                    stock.Stock = Convert.ToDouble(rdr["Stock"]);
                    // Customer.Country = rdr["Country"].ToString();
                    //Customer.City = rdr["City"].ToString();
                    lstCustomer.Add(stock);
                }
                con.Close();
            }
            return lstCustomer;
        }




        public IEnumerable<LesStocks> GetListeDemarchandiseDansUnDepot(string codeDepot)
        {
            List<LesStocks> lstCustomer = new List<LesStocks>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string s = "SELECT        tStock.CodeMarchandise, tStock.DesignationMarchandise, SUM(tMouvementDepot.QteEntree) AS SQteEntree, SUM(tMouvementDepot.QteSortie) AS SQteSortie, ROUND(SUM(tMouvementDepot.QteEntree)  " +
                     "      - SUM(tMouvementDepot.QteSortie), 2) AS Stock, tDepot.CodeDepot, tDepot.DesignationDepot " +
 " FROM            tMouvementDepot INNER JOIN " +
                         " tStock ON tMouvementDepot.CodeMarchandise = tStock.CodeMarchandise INNER JOIN " +
                         " tOperationDepot ON tMouvementDepot.NumOperation = tOperationDepot.NumOperation INNER JOIN " +
                        "  tDepot ON tMouvementDepot.CodeDepot = tDepot.CodeDepot " +
" GROUP BY tStock.CodeMarchandise, tStock.DesignationMarchandise, tDepot.CodeDepot, tDepot.DesignationDepot " +
" HAVING(tDepot.CodeDepot = @a)";
                // SqlCommand cmd = new SqlCommand("usp_GetAllCustomers", con);
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@a", codeDepot);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    LesStocks stock = new LesStocks();
                    stock.CodeMarchandise = (rdr["CodeMarchandise"]).ToString();
                    stock.DesignationMarchandise = rdr["DesignationMarchandise"].ToString();
                    stock.Stock = Convert.ToDouble(rdr["Stock"]);
                    stock.CodeDepot = (rdr["CodeDepot"]).ToString();
                    stock.DesignationDepot = rdr["DesignationDepot"].ToString();
                  
                    // Customer.Country = rdr["Country"].ToString();
                    //Customer.City = rdr["City"].ToString();
                    lstCustomer.Add(stock);
                }
                con.Close();
            }
            return lstCustomer;
        }



        public IEnumerable<LesStocks> GetListeDesDeot()
        {
            List<LesStocks> lstCustomer = new List<LesStocks>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string s = "SELECT        CodeDepot, DesignationDepot FROM            tDepot";
                // SqlCommand cmd = new SqlCommand("usp_GetAllCustomers", con);
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    LesStocks stock = new LesStocks();
                    stock.CodeDepot = (rdr["CodeDepot"]).ToString();
                    stock.DesignationDepot = rdr["DesignationDepot"].ToString();
                    //stock.Stock = Convert.ToDouble(rdr["Stock"]);
                    // Customer.Country = rdr["Country"].ToString();
                    //Customer.City = rdr["City"].ToString();
                    lstCustomer.Add(stock);
                }
                con.Close();
            }
            return lstCustomer;
        }


    }
}
