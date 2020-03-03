using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Categores_Price
    {

        public int Move_Id { get; set; }
        public int SG_Id { get; set; }
        public string SG_Name { get; set; }
        /// <summary>
        /// Relation  Foreign key  with Categores_Data table
        /// </summary>
        public int Cat_Id { get; set; }
        public virtual Categores_Data Categores_Data { get; set; }
        public string Cat_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Store_Id { get; set; }
        public int Store_Name { get; set; }
        public int U_Id { get; set; }
        public string U_Name{ get; set; }
        public int U_Number { get; set; }
        public string M_Id { get; set; }
        public string M_Name { get; set; }
        public int Bar_Id { get; set; }
        public int Article_Id { get; set; }
        public DateTime History { get; set; }
       
        
        public double Quantity { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public double DismembermentPrice { get; set; }
        public double SentencePrice { get; set; }
        public double PrivatePrice { get; set; }

    }
}
