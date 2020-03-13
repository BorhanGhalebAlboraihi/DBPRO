using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Stores_Groupe
    {

        [Key]
        public int SG_Id { get; set; }
        public virtual ICollection<Categores.Categores_Data> Categores_Datas { get; set; }
        public virtual ICollection<Stores_Transfer> Stores_Transfers { get; set; }
       // public virtual ICollection<Al_Purchases.Purchases_Returns> Purchases_Returns { get; set; }
        public virtual ICollection<Al_Purchases.Purchases__Invoice> Purchases__Invoices { get; set; }
        public virtual ICollection<Al_Purchases.Purchases_Requerts> Purchases_Requerts { get; set; }
        public virtual ICollection<Al_Sales.Sales_Invoice> Sales_Invoices { get; set; }
      //  public virtual ICollection<Al_Sales.Sales_Returns> Sales_Returns { get; set; }
        public virtual ICollection<Al_Sales.ServiceSales_Invoice> ServiceSales_Invoices { get; set; }
        public virtual ICollection<Al_Sales.Prices_Displaies> Prices_Displaies { get; set; }
        public virtual ICollection<Categores.Store_Resource> Store_Resources { get; set; }
        public virtual ICollection <Categores.Store_Outgoings> Store_Outgoings { get; set; }
       // public virtual ICollection<StoreResource_Returns> StoreResource_Returns { get; set; }
       // public virtual ICollection<StoreOutgoings_Returns> StoreOutgoings_Returns { get; set; }
        public string SG_Name { get; set; }
        public int S_Id { get; set; }
        public virtual Stores Stores { get; set; }
        public string S_Name { get; set; }
      
        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }
        public string History { get; set; }
        public string CS_Name { get; set; }
        public virtual Categores.Cat_State Cat_State { get; set; }
        public string Rank { get; set; }
    }
}
