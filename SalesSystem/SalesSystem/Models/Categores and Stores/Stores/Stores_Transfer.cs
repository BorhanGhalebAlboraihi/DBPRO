using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Stores_Transfer
    {
        //التحويل المخزني
        //Top
        public int Process_Id { get; set; }
        public DateTime History { get; set; }
        public int Tend_Id { get; set; }//رقم التحويل النهائي
        //public string from Store1 { get; set; }
        public virtual Stores Store1 { get; set; }
        //public string to Store2 { get; set; }
        public virtual Stores Store2 { get; set; }
        public int Car_Id { get; set; }//رقم السياره
        public String Care_Id { get; set; }//رقم السائق
        public string Communique { get; set; }
        /// <summary>
        /// Relation Foreign Key  with Transfer_CommandType
        /// </summary>
        public string TC_Type { get; set; }
        public virtual Transfer_CommandType Transfer_CommandType { get; set; }
        /// <summary>
        ///  Relation Foreign Key  with Stores_Groupe 
        /// </summary>
        /// Lower

        public int SG_Id { get; set; }
        public virtual Stores_Groupe Stores_Groupe { get; set; }
        public string SG_Name { get; set; }
        /// <summary>
        ///  Relation Foreign Key  Categores_Data 
        /// </summary>
        public string Cat_Id { get; set; }
        public virtual Categores.Categores_Data Categores_Data { get; set; }
        public string Cat_Name { get; set; }
        /// <summary>
        ///  Relation Foreign Key  Categores_Data 
        /// </summary>
        public int  U_Id  { get; set; }
        public virtual Stores_Units Stores_Units { get; set; }
        public string U_Name { get; set; }
        public double Quantity { get; set; }
        public DateTime BreakingHistory { get; set; }
        public double Price { get; set; }


    }
}
