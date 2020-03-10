using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class Banks
    {
        [Key]
        public int Bnk_Id { get; set; }
        public virtual ICollection<LocalAccounts.Arresting_Voucher> Arresting_Vouchers { get; set; }
        public virtual ICollection<LocalAccounts.Bank_Deposited> Bank_Depositeds { get; set; }
        public virtual ICollection<LocalAccounts.CheqesWorks> CheqesWorks { get; set; }
        public virtual ICollection<LocalAccounts.Exchange__Voucher> Exchange__Vouchers  { get; set; }
        public virtual ICollection<LocalAccounts.Employees_Activity> Employees_Activities { get; set; }
        public virtual ICollection<LocalAccounts.Salerys_Execution> Salerys_Executions { get; set; }
        public virtual ICollection<Al_Purchases.Purchases__Invoice> Purchases__Invoices { get; set; }
        public string BakArabic_Name { get; set; }
        public string BakEnglish_Name { get; set; }
        public int Bak_MainAccountNB { get; set; }
        public string Bak_Type { get; set; }
        public string Bak_State { get; set; }
        public string Bak_Netuarl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string M_Id{ get; set; }
        public virtual Moneys Moneys { get; set; }
        public int Account_Id { get; set; }
        public virtual MainAccounts Accounts { get; set; }

    }
}
