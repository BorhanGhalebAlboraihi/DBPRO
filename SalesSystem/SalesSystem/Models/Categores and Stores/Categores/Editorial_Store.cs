using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Editorial_Store
    {
        /// <summary>
        /// المخزون الافتتاحي
        /// </summary>
        public int Move_Id { get; set; }
        public int S_Id { get; set; }
        public string S_Name { get; set; }
        public int SG_Id { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id { get; set; }
        public string Cat_Name { get; set; }
        public int U_Id { get; set; }
        public string U_Name { get; set; }
        public int Numbers { get; set; }
        public DateTime BreakingHistory { get; set; }
        public string Communique { get; set; }
        public int M_Id { get; set; }
        public string M_Name { get; set; }
        /// <summary>
        /// /
        /// </summary>
        public double Store_Quantity { get; set; }//الكمية المخزنية فس البداية صفر   
        public double EditorialStore { get; set; }//المخزون الافتتاحي
        public double CostPrice { get; set; }
        public double Total { get; set; }

    }
}
