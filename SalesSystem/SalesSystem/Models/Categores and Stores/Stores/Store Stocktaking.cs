using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Store_Stocktaking
    {
        //الجرد المخزتي
        public int Move_Id { get; set; }
        public int SG_Id { get; set; }
       public string SG_Name { get; set; }
        public string Store { get; set; }
        public int Cat_Id { get; set; }
        public string Cat_Name { get; set; }
        /// <summary>
        ///  الكمية المتبقية في المخازن في النظام المحاسبي
        /// </summary>
        public double Quantity { get; set; }
        /// <summary>
        /// الجرد المخزني اليدوي للمخازن الفعلية في الواقع 
        /// </summary>
        public double Stocktaking { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Unit { get; set; }
        public DateTime History { get; set; }
        /// <summary>
        /// Relationship Foreign Key with Racks_Table
        /// </summary>
        public int Ranks_Id { get; set; }
        public virtual Categores.Racks_Table Racks_Table { get; set; }
        public string Ranks_Specification { get; set; }
    }
}

