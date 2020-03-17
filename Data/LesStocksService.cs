using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBlazor.Data
{
    public class LesStocksService
    {

        LesStockDataAccessLayer objCustomerDAL = new LesStockDataAccessLayer();
         public List<LesStocks> GetLesStock()
        {
            List<LesStocks> ListeStock = objCustomerDAL.GetLesStocks().ToList();
            return ListeStock;
        }


        public List<LesStocks> GetLESsTOCKparDepot( string CodeMarchanandise)
        {
            List<LesStocks> ListeStock = objCustomerDAL.GetLesStockParDepot(CodeMarchanandise).ToList();
            return ListeStock;
        }


        public List<LesStocks> GetListeDeStockMarchandiseDansUnDepot(string CodeDepot)
        {
            List<LesStocks> ListeStock = objCustomerDAL.GetListeDemarchandiseDansUnDepot(CodeDepot).ToList();
            return ListeStock;
        }


        public List<LesStocks> GetListeDepot(string CodeMarchanandise)
        {
            List<LesStocks> ListeStock = objCustomerDAL.GetListeDesDeot().ToList();
            return ListeStock;
        }
    }
}
