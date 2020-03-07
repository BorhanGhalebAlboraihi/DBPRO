using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Units_Order
    {
        public int Move_Id { get; set; }
        public int SG_Id { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id { get; set; }   
        public virtual Categores_Data Categores_Data { get; set; }
        public string Cat_Name { get; set; }
        /// <summary>
        /// Relation  Foreign key  with Units table
        /// </summary>
        public int U_Id { get; set; }
        public virtual Stores.Stores_Units Stores_Units { get; set; }
        public string U_Name { get; set; }
        public double Number { get; set; }
        /// <summary>
        /// Relation  Foreign key  with Barcode table
        /// </summary>
     
     

    }
}
