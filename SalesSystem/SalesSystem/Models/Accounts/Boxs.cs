using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class Boxs
    {
        [Key]
        public int Box_Id { get; set; }
        public virtual ICollection<LocalAccounts.Arresting_Voucher> Arresting_Vouchers { get; set; }
        public virtual ICollection<LocalAccounts.Exchange__Voucher> Exchange__Vouchers { get; set; }
        public virtual ICollection<LocalAccounts.Employees_Activity> Employees_Activities { get; set; }
        public virtual ICollection<LocalAccounts.Salerys_Execution> Salerys_Executions { get; set; }
        public virtual ICollection<Al_Purchases.Purchases__Invoice> Purchases__Invoices { get; set; }
       // public virtual ICollection<Al_Purchases.Purchases_Returns> Purchases_Returns { get; set; }
        public virtual ICollection<Al_Purchases.Purchases_Requerts> Purchases_Requerts { get; set; }
        public virtual ICollection<Al_Purchases.Purchases_Commands> Purchases_Commands { get; set; }
        public virtual ICollection<Al_Sales.Sales_Invoice> Sales_Invoices { get; set; }
       // public virtual ICollection<Al_Sales.Sales_Returns> Sales_Returns { get; set; }
        public virtual ICollection<Al_Sales.ServiceSales_Invoice> ServiceSales_Invoices { get; set; }
        public virtual ICollection<Al_Sales.Prices_Displaies> Prices_Displaies { get; set; }
        public virtual ICollection<Categores_and_Stores.Categores.Store_Resource> Store_Resources { get; set; }
        public virtual ICollection<Categores_and_Stores.Categores.Store_Outgoings> Store_Outgoings { get; set; }
       // public virtual ICollection<Categores_and_Stores.Stores.StoreResource_Returns> StoreResource_Returns { get; set; }
      //  public virtual ICollection<Categores_and_Stores.Stores.StoreOutgoings_Returns> StoreOutgoings_Returns { get; set; }
        public string BoxArabic_Name { get; set; }
        public string BoxEnglish_Name { get; set; }
        public int Box_MainAccountNB { get; set; }
        public string Box_Type { get; set; }
        public string Box_State { get; set; }
        public string Box_Netuarl { get; set; }
        public int C_Id { get; set; }
        public string C_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string M_Id { get; set; }
        public virtual Moneys Moneys { get; set; }
        public int Account_Id { get; set; }
        public virtual MainAccounts Accounts { get; set; }
    }
}
