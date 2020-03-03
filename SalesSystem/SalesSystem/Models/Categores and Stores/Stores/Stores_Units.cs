using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Stores_Units
    {
        /// <summary>
        /// يتم اضافة الوحدات التي يتم التعامل معها من خلال الاصناف المخزنيه. (شكل رقم 25)
        /// </summary>

        [Key]
        public int U_Id { get; set; }
        public string U_Name { get; set; }//aribic
        public string EU_Name { get; set; }//English
        public int Number { get; set; }
        public string Rank_Id { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
    }
}

