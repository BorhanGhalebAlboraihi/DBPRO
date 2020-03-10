using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class MainAccounts
    {
        //الدليل المحاسبي العام
          [Key]
        public int Account_Id { get; set; }
        public virtual ICollection<Banks> Banks { get; set; }
        public virtual ICollection<Boxs> Boxs { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Suppliers> Suppliers { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<BillsSetting.Summation> Summations { get; set; }
        public virtual ICollection<Categores_and_Stores.Stores. Stores_Groupe> Stores_Groupes { get; set; }
        public virtual ICollection<Categores_and_Stores.Stores.Stores> Stores { get; set; }
        public virtual ICollection<Editorial_Accounts.Editorial_Accounts> Editorial_Accounts { get; set; }
        public virtual ICollection<Primary_Accounts> Primary_Accounts { get; set; }
        public virtual ICollection <Categores_and_Stores.Categores.Store_Outgoings> Store_Outgoings { get; set; }
        public virtual ICollection<LocalAccounts.Bank_Deposited> Bank_Depositeds { get; set; }
        public virtual ICollection<LocalAccounts.Bank_Drafting> Bank_Draftings { get; set; }
        public virtual ICollection<LocalAccounts.CheqesWorks> CheqesWorks { get; set; }
        public virtual ICollection<LocalAccounts.Conciliator_Accounts> Conciliator_Accounts { get; set; }
        public virtual ICollection<LocalAccounts.Exchange__Voucher> Exchange__Vouchers { get; set; }
        public virtual ICollection<Al_Purchases.Purchases__Invoice> Purchases__Invoices { get; set; }
        public virtual ICollection<Al_Purchases.Purchases_Returns> Purchases_Returns { get; set; }
        public virtual ICollection<Al_Sales.Sales_Invoice> Sales_Invoices { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Account_Name { get; set; }
        public double MainAccount_Id { get; set; }
        public string Account_Netural { get; set; }
        public string Account_Main { get; set; }
        public string Account_State { get; set; }
        public string Account_Confidentility { get; set; }//السرية

        /// <summary>
        /// Forign key Rank
        /// </summary>
         public string Rank_Name { get; set; }
        public virtual AccountsRanks Account { get; set; }
         public string Groupe_Name { get; set; }
        public virtual AccountsGroupe Accounts { get; set; }
        /// <summary>
        /// foreign Key with CostCenter
        /// </summary>
        public int C_Id { get; set; }
        public virtual CostCenters.CostCenter CostCenter  { get; set; }
        public string C_Name { get; set; }
        public string Type_Name { get; set; }
        public virtual AccountsTypes Accounte { get; set; }
        public string M_Name{ get; set; }
        public virtual Moneys Moneys { get; set; }



    }
}
