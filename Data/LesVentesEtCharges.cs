using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBlazor.Data
{
    public class LesVentesEtCharges
    {

        public string NumCompte { get; set; }
      
        public string DesignationCompte { get; set; }

      
        public Double SDebitCharge { get; set; }
        public Double SCreditProduit { get; set; }
        public Double ObjectifVenteJournalier { get; set; }
        public Double PourCentageVente { get; set; }

       

    }
}
