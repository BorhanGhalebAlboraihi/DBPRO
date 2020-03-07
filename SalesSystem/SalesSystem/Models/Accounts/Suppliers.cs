using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class Suppliers
    {

        [Key]
        public int Sup_Id { get; set; }
        public virtual ICollection<Categores_and_Stores.Categores.Store_Outgoings> Store_Outgoinge { get; set; }
        public virtual ICollection<Categores_and_Stores.Categores.Store_Resource> Store_Resources { get; set; }
        public virtual ICollection<LocalAccounts.Bank_Drafting> Bank_Draftings { get; set; }
        public virtual ICollection<LocalAccounts.Arresting_Voucher> Arresting_Vouchers { get; set; }
        public virtual ICollection<Al_Purchases.Purchases__Invoice> Purchases__Invoices { get; set; }
        public string Sup_Name { get; set; }
        public int Sup_MainAccountNB { get; set; }
        public string Sup_Rank { get; set; }
        public string Sup_Address { get; set; }
        public string Sup_Netuarl { get; set; }
        public string Sup_State { get; set; }
        public double Sup_phone { get; set; }
        public DateTime Sup_History { get; set; }
        public string Sup_SalePrice { get; set; }//سعر البيع للعميل
        public string Sup_SaleMoney { get; set; }//عملة البيع للعميل
        public double Sup_DebtorsTop { get; set; }//اعلى مديونية للعميل
        public string Sup_DebtorsTime { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Area_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sup_Type { get; set; }
        public virtual BillsSetting.BillsVariables.SupllierType SupllierType { get; set; }
        public int S_Id { get; set; }//الموزع
        public virtual BillsSetting.Summation Summation { get; set; }
        public string S_Name { get; set; }//الموزع
        public int A_Id  { get; set; }
        public virtual BillsSetting.SalesAreas SalesAreas { get; set; }
        public string A_Name { get; set; }
        public int Account_Id { get; set; }// الدليل المحاسبي
        public virtual MainAccounts Accounts { get; set; }
       public string M_Name { get; set; }
        public virtual Moneys Moneys { get; set; }

    }
}
