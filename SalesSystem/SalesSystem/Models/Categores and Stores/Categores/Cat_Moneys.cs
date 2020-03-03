using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Cat_Moneys
    {
        [Key]
        public int M_Id { get; set; }
        public string M_Name { get; set; }
        public string M_Symbole { get; set; }
        public string M_Barket { get; set; }//الفئة
        public double M_Pric { get; set; }// سعر تحويل
        public double M_PriceTop { get; set; }//اعلى سعر تحويل
        public double M_PriceLess { get; set; }//اقل سعر تحويل
        public string M_Country { get; set; }
        public string M_State { get; set; }
        public string M_Type { get; set; }
        public DateTime M_History { get; set; }
    }
}
