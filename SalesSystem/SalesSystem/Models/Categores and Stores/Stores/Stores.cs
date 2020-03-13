using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Stores
    {
        [Key]
        public int S_Id { get; set; }
        public virtual ICollection<Stores_Groupe> Stores_Groupes { get; set; }
        public virtual ICollection<Categores.Racks_Table> Racks_Tables { get; set; }
        public virtual ICollection<Al_Purchases.Purchases__Invoice> Purchases__Invoices { get; set; }
       // public virtual ICollection<Al_Purchases.Purchases_Returns> Purchases_Returns { get; set; }
        public virtual ICollection<Al_Purchases.Purchases_Requerts> Purchases_Requerts { get; set; }
        public virtual ICollection<Al_Purchases.Purchases_Commands> Purchases_Commands { get; set; }
        public virtual ICollection<Al_Sales.Sales_Invoice> Sales_Invoices { get; set; }
       // public virtual ICollection<Al_Sales.Sales_Returns> Sales_Returns { get; set; }
        public virtual ICollection<Al_Sales.ServiceSales_Invoice> ServiceSales_Invoices { get; set; }
        public virtual ICollection<Al_Sales.Prices_Displaies> Prices_Displaies { get; set; }
        public virtual ICollection<Categores.Store_Resource> Store_Resources { get; set; }
        public virtual ICollection<Categores.Store_Outgoings> Store_Outgoings { get; set; }
       // public virtual ICollection<StoreResource_Returns> StoreResource_Returns { get; set; }
       // public virtual ICollection<StoreOutgoings_Returns> StoreOutgoings_Returns { get; set; }
        public virtual ICollection<Stores_Transfer> Stores_Transfers { get; set; }
        public string S_Name { get; set; }
        public string WopS_Name { get; set; }//اسم المخزن الاجنبي
        public int Account_Id { get; set; }
        public virtual Accounts.MainAccounts MainAccounts { get; set; }
        public int M_Id { get; set; }
        public virtual Moneys Moneys { get; set; }
        public virtual Accounts.System_Money System_Money { get; set; }
        public string M_Name { get; set; }
        public double Phone { get; set; }
        public string CS_Name { get; set; }
        public virtual Categores.Cat_State Cat_State { get; set; }
        public string Address { get; set; }
        public string Store_Honest { get; set; }//امين المخزن
        public string Location { get; set; }
        public DateTime History { get; set; }
    }
}
