using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBlazor.Data
{
    public class LesVentesEtChargeService
    {

        LesVentesEtChargesDataAccessLayer objLesVente = new LesVentesEtChargesDataAccessLayer();
        public LesVentesEtCharges GetVenteJoornaliere( DateTime date1, DateTime date2)
        {
            LesVentesEtCharges VenteJ = objLesVente.GetVenteJournaliere(date1, date2);
            return VenteJ;
        }


        public LesVentesEtCharges GetChargeStockage(DateTime date1, DateTime date2)
        {
            LesVentesEtCharges ChargeStockage = objLesVente.GetChargeStockage(date1, date2);
            return ChargeStockage;
        }


    }
}
