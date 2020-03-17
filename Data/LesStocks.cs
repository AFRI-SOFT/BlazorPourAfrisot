using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CRUDBlazor.Data
{
    public class LesStocks
    {

        public string CodeMarchandise { get; set; }
        [Required]
        public string DesignationMarchandise { get; set; }

        [Required]
        public Double Stock { get; set; }
        [Required]
        public string CategorieStock { get; set; }

        public string DesignationDepot { get; set; }

        public string CodeDepot { get; set; }

        //public string Gender { get; set; }

    }
}
