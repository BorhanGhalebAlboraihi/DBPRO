using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class Moneys
    {
      
       
        public int _Id { get; set; }
        [Key]
        public string M_Name { get; set; }
        public virtual ICollection<Banks> Banks { get; set; }
        public virtual ICollection<Boxs> Boxs { get; set; }
        public virtual ICollection<MainAccounts> MainAccounts { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Suppliers> Suppliers { get; set; }
        public virtual ICollection <Editorial_Accounts.Editorial_Accounts> Editorial_Accounts { get; set; }
        public virtual ICollection<LocalAccounts.Arresting_Voucher> Arresting_Vouchers { get; set; }
        public virtual ICollection<LocalAccounts.Bank_Deposited> Bank_Depositeds { get; set; }
        public virtual ICollection<LocalAccounts.CheqesWorks> CheqesWorks { get; set; }
        public virtual ICollection<LocalAccounts.Exchange__Voucher> Exchange__Vouchers { get; set; }
        public virtual ICollection<LocalAccounts.EmployeeMove_Type> EmployeeMove_Types { get; set; }
        public virtual ICollection<Al_Purchases.Purchases__Invoice> Purchases__Invoices { get; set; }
      //  public virtual ICollection<Al_Purchases.Purchases_Returns> Purchases_Returns { get; set; }
        public virtual ICollection<Al_Sales.Sales_Invoice> Sales_Invoices { get; set; }
       // public virtual ICollection<Al_Sales.Sales_Returns> Sales_Returns { get; set; }
        public virtual ICollection<Al_Sales.ServiceSales_Invoice> ServiceSales_Invoices { get; set; }
        public virtual ICollection<Al_Sales.Prices_Displaies> Prices_Displaies { get; set; }
        public virtual ICollection<AccountingMoves_Migration.CeshVouchers_Migration> CeshVouchers_Migrations { get; set; }
        public string M_Symbole { get; set; }
        public string M_Barket { get; set; }//الفئة
        public double M_Pric { get; set; }// سعر تحويل
        public double M_PriceTop { get; set; }//اعلى سعر تحويل
        public double M_PriceLess { get; set; }//اقل سعر تحويل
        public string M_Country { get; set; }
        public string M_State { get; set; }
        public string M_Type { get; set; }
        public DateTime M_History { get; set; }
    }
}
