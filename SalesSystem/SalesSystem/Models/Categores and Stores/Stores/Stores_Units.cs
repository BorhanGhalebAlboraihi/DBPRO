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
        public virtual ICollection<Categores.Categores_Data> Categores_Datas { get; set; }
        public virtual ICollection<Categores.Units_Order> Units_Orders { get; set; }
        public virtual ICollection<Barcode> Barcodes { get; set; }
        public virtual ICollection<Al_Purchases.Purchases_Requerts> Purchases_Requerts { get; set; }
        public virtual ICollection<Categores.Categores_Lower_and_Top> GetCategores_Lower_And_Tops { get; set; } 
        public virtual ICollection<Categores.Store_Resource> Store_Resources { get; set; }
        public virtual ICollection<Categores.Store_Outgoings> Store_Outgoings { get; set; }
       // public virtual ICollection<StoreResource_Returns> StoreResource_Returns { get; set; }
       // public virtual ICollection<StoreOutgoings_Returns> StoreOutgoings_Returns { get; set; }
        public virtual ICollection<Stores_Transfer> Stores_Transfers { get; set; }
        public string U_Name { get; set; }//aribic
        public string EU_Name { get; set; }//English
        public int Number { get; set; }
        public string Rank_Id { get; set; }
        public string Type { get; set; }
        public string CS_Name { get; set; }
        public virtual Categores.Cat_State Cat_State { get; set; }
    }
}

